using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class HookOption : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        BipedTransformation biped = other.GetComponent<BipedTransformation>();
        if (biped)
        {
            biped.HookOptions.Add(this);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        BipedTransformation biped = other.GetComponent<BipedTransformation>();
        if (biped)
        {
            biped.HookOptions.Remove(this);
        }
    }
}
