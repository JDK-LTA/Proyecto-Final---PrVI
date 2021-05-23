using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class PlayerKiller : MonoBehaviour
{
    [SerializeField] private float killDelay;
    private Cinemachine.CinemachineFreeLook cmBrain;
    private Rigidbody rb;

    private void Awake()
    {
        gameObject.layer = 2;
        cmBrain = FindObjectOfType<Cinemachine.CinemachineFreeLook>();
        rb = GetComponent<Rigidbody>();
        if (!rb)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }

        rb.useGravity = false;
        rb.isKinematic = true;
        rb.constraints = RigidbodyConstraints.FreezeAll; 
        GetComponent<BoxCollider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            cmBrain.Follow = null;
            CheckpointManager.Instance.DelayedRespawn(killDelay);
        }
    }
}
