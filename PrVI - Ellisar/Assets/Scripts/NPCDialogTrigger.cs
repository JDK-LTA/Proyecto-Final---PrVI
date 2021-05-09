using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogTrigger : MonoBehaviour
{
    [SerializeField] private Texter texter;
    [SerializeField] private Canvas pressToAct;

    public void OnTriggerEnter(Collider other)
    {
        PlayerMovement pl = other.GetComponent<PlayerMovement>();
        if (pl)
        {
            pl.CanInteract = true;
            pl.InteractableDialog = this;
            if (pressToAct)
                pressToAct.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerMovement pl = other.GetComponent<PlayerMovement>();
        if (pl)
        {
            pl.CanInteract = false;
            pl.InteractableDialog = null;
            if (pressToAct)
                pressToAct.gameObject.SetActive(false);
        }
    }
    public void EnableTexter()
    {
        texter.enabled = true;
    }
}
