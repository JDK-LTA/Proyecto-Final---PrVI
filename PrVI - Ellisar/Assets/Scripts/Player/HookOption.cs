using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class HookOption : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement biped = other.GetComponent<PlayerMovement>();
        if (biped)
        {
            biped.HookOptions.Add(this);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerMovement biped = other.GetComponent<PlayerMovement>();
        if (biped)
        {
            biped.HookOptions.Remove(this);
        }
    }
}
