using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class HookOption : MonoBehaviour
{
    [SerializeField] public float forceOfHook = 100;
    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement biped = other.GetComponent<PlayerMovement>();
        if (biped)
        {
        //print("ddd");
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
