using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerParent : MonoBehaviour
{
    protected MovHandler handler;
    protected Camera cam;
    protected Animator animator;
    protected Rigidbody rb;

    protected void Awake()
    {
        handler = GetComponent<MovHandler>();
        //CHANGE THIS IF MULTI-CAMERA SYSTEM
        cam = Camera.main;
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
    }
}
