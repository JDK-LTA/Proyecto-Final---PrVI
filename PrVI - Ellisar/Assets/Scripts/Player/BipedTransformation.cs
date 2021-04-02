using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BipedTransformation : Transformation
{
    [SerializeField] private float walkingSpeed = 5f, rotatingSpeed = 5f;

    [SerializeField] private float jumpForce;
    [SerializeField] private ForceMode appliedForceMode;

    [SerializeField] private bool isJumping;

    [SerializeField] private float currentSpeed;

    private void Update()
    {
        RaycastHit hit;
        Vector3 groundPos;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
        {
            groundPos = hit.point;

            float distanceToGround = Vector3.Distance(transform.position, groundPos);
            if (distanceToGround > 1)
            {
                isJumping = false;
            }
        }
        currentSpeed = rb.velocity.magnitude;
    }
    private void FixedUpdate()
    {
        rb.AddRelativeForce(new Vector3(0, 0, moveInputVector.y * walkingSpeed));
        rb.AddRelativeTorque(new Vector3(0, moveInputVector.x * rotatingSpeed, 0));
        //rb.MovePosition(transform.position + Time.deltaTime * walkingSpeed * transform.TransformDirection(moveInputVector.x, 0, moveInputVector.y));
    }
    public override void JumpAction(InputAction.CallbackContext cxt)
    {
        if (!isJumping)
        {
            rb.AddForce(jumpForce * Vector3.up, appliedForceMode);
        }
    }
}
