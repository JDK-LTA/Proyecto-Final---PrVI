using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public GameObject panel;
    public int valor;
    public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerMovement>())
        {
            Debug.Log("hola");

            this.gameObject.GetComponent<Dialogos>().AbrirCajaDialogo(0);

        }
    }
}
