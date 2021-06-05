using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

[System.Serializable]
public class UIFeathers
{
    public Image featherOut, featherBg, featherRotator;
    public List<Image> featherIns = new List<Image>();
    [HideInInspector]
    public bool canRotate = true;
}
public class UI_FlapsEnergy : Singleton<UI_FlapsEnergy>
{
    [SerializeField] private List<Image> featherIns;
    [SerializeField] private List<UIFeathers> feathers = new List<UIFeathers>();
    [SerializeField] private Color red, blue, green;
    [SerializeField] private float rotatorsSpeed = 25;
    [SerializeField] private Text featherText, energyText;
    [SerializeField] private GameObject controlsPanel;
    private Text controlsText;
    private int energyTotal = 0;
    private int feathersTotal = 3;

    private static string gamepadText = "Controls:\nLeft Joystick - Movement\nRight Joystick - Camera\nX - Jump(if biped)\nR2 - Hook(biped) / Flap wings / Bomb forward\nL2 - Bomb down(ball)\nL1 + X - Biped mode\nL1 + ▲ - Flight mode\nL1 + ◯ - Ball mode\nR3 (hold) - Respawn\nUp Arrow - Invert Camera Y Axis\nDown Arrow - Invert Y Flight Movement\n<- + -> Arrows - More/Less Cam Sensibility";
    private static string keyboardText = "Controls:\nWASD - Movement\nMouse - Camera\nSpace - Jump (biped)\nQ - Hook(biped) / Flap wings / Bomb forward\nE - Bomb down(ball)\n1 - Biped mode\n2 - Flight mode\n3 - Ball mode\nR (hold) - Respawn\nY - Invert Camera Y Axis\nU - Invert Y Flight Movement\n, and . - More/Less Cam Sensibility";

    private void Start()
    {
        controlsText = controlsPanel.GetComponentInChildren<Text>();
    }

    private void Update()
    {
        foreach (UIFeathers item in feathers)
        {
            if (item.canRotate)
                item.featherRotator.rectTransform.Rotate(Vector3.forward, rotatorsSpeed * Time.deltaTime, Space.Self);
        }
    }
    public void ToggleShowControls(InputAction.CallbackContext cxt)
    {
        if (cxt.performed)
        {
            controlsPanel.SetActive(!controlsPanel.activeInHierarchy);
        }
    }
    public void ChangeControlsText(PlayerInput input)
    {
        if (input.currentControlScheme == "Gamepad")
        {
            controlsText.text = gamepadText;
        }
        else
        {
            controlsText.text = keyboardText;
        }
    }
    public void UpdateFeatherText(int amount)
    {
        //featherText.text = amount.ToString();
        feathersTotal = amount;
        for (int i = 0; i < feathersTotal; i++)
        {
            feathers[i].canRotate = true;
        }
        for (int i = feathersTotal; i < 3; i++)
        {
            feathers[i].canRotate = false;
        }
    }
    public void UpdateEnergyText(int amount)
    {
        energyText.text = amount.ToString();
    }
    public void SumEnergy()
    {
        energyTotal++;
        UpdateEnergyText(energyTotal);
    }
    public void UpdateFeatherImage(float fill)
    {
        if (fill <= 1f / 8f)
        {
            feathers[feathersTotal].featherIns[0].fillAmount = fill * 8;
            for (int i = 1; i < featherIns.Count; i++)
            {
                feathers[feathersTotal].featherIns[i].fillAmount = 0;
            }
        }
        else if (fill <= 2f / 8f)
        {
            feathers[feathersTotal].featherIns[1].fillAmount = (fill - 1f / 8f) * 8;
            for (int i = 2; i < featherIns.Count; i++)
            {
                feathers[feathersTotal].featherIns[i].fillAmount = 0;
            }
        }
        else if (fill <= 3f / 8f)
        {
            feathers[feathersTotal].featherIns[2].fillAmount = (fill - 2f / 8f) * 8;
            for (int i = 3; i < featherIns.Count; i++)
            {
                feathers[feathersTotal].featherIns[i].fillAmount = 0;
            }
        }
        else if (fill <= 4f / 8f)
        {
            feathers[feathersTotal].featherIns[3].fillAmount = (fill - 3f / 8f) * 8;
            for (int i = 4; i < featherIns.Count; i++)
            {
                feathers[feathersTotal].featherIns[i].fillAmount = 0;
            }
        }
        else if (fill <= 5f / 8f)
        {
            feathers[feathersTotal].featherIns[4].fillAmount = (fill - 4f / 8f) * 8;
            for (int i = 5; i < featherIns.Count; i++)
            {
                feathers[feathersTotal].featherIns[i].fillAmount = 0;
            }
        }
        else if (fill <= 6f / 8f)
        {
            feathers[feathersTotal].featherIns[5].fillAmount = (fill - 5f / 8f) * 8;
            for (int i = 6; i < featherIns.Count; i++)
            {
                feathers[feathersTotal].featherIns[i].fillAmount = 0;
            }
        }
        else if (fill <= 7f / 8f)
        {
            feathers[feathersTotal].featherIns[6].fillAmount = (fill - 6f / 8f) * 8;
            for (int i = 7; i < featherIns.Count; i++)
            {
                feathers[feathersTotal].featherIns[i].fillAmount = 0;
            }
        }
        else
        {
            feathers[feathersTotal].featherIns[7].fillAmount = (fill - 7f / 8f) * 8;
        }

        if (feathersTotal < 2)
        {
            for (int i = feathersTotal + 1; i < feathers.Count; i++)
            {
                UIFeathers fea = feathers[i];
                foreach (Image item in fea.featherIns)
                {
                    item.fillAmount = 0;
                }
            }
        }
    }

    public void FeatherRotsToRed()
    {
        foreach (UIFeathers item in feathers)
        {
            item.featherRotator.color = red;
        }
    }
    public void FeatherRotsToBlue()
    {
        foreach (UIFeathers item in feathers)
        {
            item.featherRotator.color = blue;
        }
    }
    public void FeatherRotsToGreen()
    {
        foreach (UIFeathers item in feathers)
        {
            item.featherRotator.color = green;
        }
    }
}
