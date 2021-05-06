using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogTrigger : MonoBehaviour
{
    [SerializeField]
    private Texter texto;
    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {


           texto.enabled = true;

        }
    }
}
