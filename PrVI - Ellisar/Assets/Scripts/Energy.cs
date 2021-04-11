using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            UI_FlapsEnergy.Instance.SumEnergy();
            Destroy(gameObject);
        }
    }
}
