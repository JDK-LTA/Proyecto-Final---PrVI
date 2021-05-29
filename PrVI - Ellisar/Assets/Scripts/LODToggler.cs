using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]
public class LODToggler : MonoBehaviour
{
    [SerializeField] private LODSZones zoneToToggle;
    [SerializeField] private bool active;

    private void Start()
    {
        GetComponent<BoxCollider>().isTrigger = true;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = true;
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            LODSManager.Instance.SetLODActive(zoneToToggle, active);
        }
    }
}
