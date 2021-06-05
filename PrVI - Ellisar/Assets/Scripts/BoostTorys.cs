using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostTorys : MonoBehaviour
{
    [SerializeField] private float amount = 10f;
    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement pl = other.GetComponent<PlayerMovement>();
        if (pl)
        {
            pl.SpeedBoost(amount);
        }
    }
}
