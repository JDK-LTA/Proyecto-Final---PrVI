using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    protected CharacterController controller;
    protected MovementHandler handler;
    [HideInInspector] public Camera cam;
    protected Animator animator;
    protected Rigidbody rb;

    protected void Awake()
    {
        controller = GetComponent<CharacterController>();
        handler = GetComponent<MovementHandler>();
        cam = GameObject.Find("MainCamera").GetComponent<Camera>();
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    protected bool RayCasting(List<Transform> listOfCheckers, float distance, LayerMask layerMask)
    {
        foreach (Transform check in listOfCheckers)
        {
            if (Physics.Raycast(check.position, Vector3.down, distance, layerMask))
            {
                return true;
            }
        }
        return false;
    }

}
