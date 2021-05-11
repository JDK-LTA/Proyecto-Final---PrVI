using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    [SerializeField] private string rewardText = "You found the cave secret #1!";
    [SerializeField] private Text canvasText;

    private void Start()
    {
        if (!canvasText)
        {
            canvasText = FindObjectOfType<SelfDeactivate>(true).GetComponent<Text>();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            if (canvasText)
            {
                canvasText.text = rewardText;
                canvasText.transform.parent.gameObject.SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}
