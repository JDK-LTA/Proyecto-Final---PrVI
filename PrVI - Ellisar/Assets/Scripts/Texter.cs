using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct BetterParagraph
{
    [TextArea]
    public string text;
    //public float timeToFinishParagraph;
    public float timeAfterParagraph;
    public float timeBetweenLetters;
}

public class Texter : MonoBehaviour
{
    [SerializeField] private bool deleteAfterParagraph = true;
    [SerializeField] private bool deleteAfterFullText = true;
    [SerializeField] private List<BetterParagraph> paragraphs = new List<BetterParagraph>();
    #region DEPRECATED
    private RectTransform startingPos, endingPos, posToStopSign;
    private Transform endSignParent;
    private float timeToEndRoll;
    private Image signature;
    private bool rolling = false, showSignature = false, hideSignature = false;
    private float signatureFadeTimer = 3.8f;
    #endregion

    private string auxText = "";
    private Text textComponent;
    private RectTransform rectTransform;

    private float auxT = 0, auxRoll = 0, auxParT = 0;
    private int letterCount = 0, lettersThisLoop = 0, paragraphCount = 0, loopsToWriteNextLetter = 0;
    private float accumulatorOfDecimals = 0, auxAccumulation = 0;

    private bool writing = false;
    private bool paragraphEnd = false;

    private float debugT = 0;

    private void OnEnable()
    {
        textComponent = GetComponent<Text>();
        rectTransform = GetComponent<RectTransform>();

        writing = true;
        //rolling = true;

        float secsToWrite = 0;
        for (int i = 0; i < paragraphs.Count; i++)
        {
            BetterParagraph par = paragraphs[i];

            if (par.timeBetweenLetters < 0.005)
            {
                par.timeBetweenLetters = 0.005f;
                throw new System.Exception("Time between letters on paragraph number " + i + " is too low. It's been defaulted to 0.005");
            }
            if (par.timeAfterParagraph < 0.005)
            {
                par.timeAfterParagraph = 0.005f;
                throw new System.Exception("Time after paragraph on paragraph number " + i + " is too low. It's been defaulted to 0.005");
            }

            secsToWrite += (par.timeBetweenLetters * par.text.Length) + par.timeAfterParagraph;
        }
        print("secs to write: " + secsToWrite);
    }
    private void Update()
    {
        if (writing)
        {
            WriteV2();
        }
        if (paragraphEnd)
        {
            ParagraphEndTimer();
        }
        debugT += Time.deltaTime;
    }

    private void Roll()
    {
        auxRoll += Time.unscaledDeltaTime;
        rectTransform.position = new Vector3(rectTransform.position.x,
            Mathf.Lerp(startingPos.position.y, endingPos.position.y, auxRoll / timeToEndRoll),
            rectTransform.position.z);

        if (auxRoll >= timeToEndRoll)
        {
            rectTransform.position = new Vector3(rectTransform.position.x, endingPos.position.y, rectTransform.position.z);
        }

        if (rectTransform.position.y > posToStopSign.position.y)
        {
            signature.transform.parent = endSignParent;
        }
    }
    private void HideSignature()
    {
        auxT += Time.unscaledDeltaTime;
        signature.color = new Color(signature.color.r, signature.color.g, signature.color.b, 1 - auxT / signatureFadeTimer);
        if (auxT >= signatureFadeTimer)
        {
            auxT = 0;
            signature.color = new Color(signature.color.r, signature.color.g, signature.color.b, 0);
            hideSignature = false;
            Invoke("TriggerRestart", 0.5f);
        }
    }
    private void ShowSignature()
    {
        auxT += Time.unscaledDeltaTime;
        signature.color = new Color(signature.color.r, signature.color.g, signature.color.b, auxT / signatureFadeTimer);
        if (auxT >= signatureFadeTimer)
        {
            auxT = 0;
            signature.color = new Color(signature.color.r, signature.color.g, signature.color.b, 1);
            showSignature = false;
            Invoke("StartHidingSignature", 7);
        }
    }
    private void Write()
    {
        auxT += Time.deltaTime;
        loopsToWriteNextLetter++;

        if (auxT >= paragraphs[paragraphCount].timeBetweenLetters)
        {
            if (loopsToWriteNextLetter == 1)
            {
                //lettersThisLoop = (int)((Time.deltaTime / paragraphs[paragraphCount].timeBetweenLetters) + 1);

                auxAccumulation = (Time.deltaTime / paragraphs[paragraphCount].timeBetweenLetters) + 1;
                lettersThisLoop = (int)auxAccumulation;
                accumulatorOfDecimals += auxAccumulation - lettersThisLoop;

                if (accumulatorOfDecimals > 1)
                {
                    lettersThisLoop++;
                    accumulatorOfDecimals--;
                }

                for (int i = 0; i < lettersThisLoop; i++)
                {
                    WriteLetter();
                }
            }
            else
            {
                print("ejem");
                WriteLetter();
            }

            auxT = 0;
            loopsToWriteNextLetter = 0;
        }
    }

    private void WriteV2()
    {
        auxT += Time.deltaTime;

        while (paragraphCount < paragraphs.Count && auxT >= paragraphs[paragraphCount].timeBetweenLetters)
        {
            auxT -= paragraphs[paragraphCount].timeBetweenLetters;
            WriteLetter();
        }
    }

    private void WriteLetter()
    {
        auxText += paragraphs[paragraphCount].text[letterCount];
        textComponent.text = auxText;

        letterCount++;
        CheckIfEndOfParagraph();
    }

    private void CheckIfEndOfParagraph()
    {
        if (letterCount >= paragraphs[paragraphCount].text.Length)
        {
            letterCount = 0;
            paragraphEnd = true;
            writing = false;
        }
    }

    private void ParagraphEndTimer()
    {
        auxParT += Time.deltaTime;

        if (auxParT >= paragraphs[paragraphCount].timeAfterParagraph)
        {
            auxParT = 0;

            if (deleteAfterParagraph)
            {
                auxText = "";
                textComponent.text = auxText;
            }
            else
            {
                auxText += "\n";
                textComponent.text = auxText;
            }
            writing = true;
            paragraphCount++;
            paragraphEnd = false;
            CheckIfEndOfText();
        }
    }

    private void CheckIfEndOfText()
    {
        if (paragraphCount >= paragraphs.Count)
        {
            writing = false;
            auxT = 0;

            auxText = "";
            textComponent.text = auxText;

            print("real secs to be written: " + debugT);
        }
    }

    //private void StartHidingSignature()
    //{
    //    hideSignature = true;
    //}
    //private void TriggerRestart()
    //{
    //    GameManager.Instance.RestartWholeGame();
    //}
}
