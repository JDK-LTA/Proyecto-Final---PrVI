using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class FlightTransformation : Transformation
{
    [SerializeField] protected float wingBeatHeight = 3f;
    [SerializeField] private float energy = 0, fall = 0, airSpeed = 0;

    private void Update()
    {
        energy = transform.position.y + rb.velocity.magnitude;
    }

    private void FixedUpdate()
    {
        float roll = -moveInputVector.x;
        float tilt = moveInputVector.y;

        if (tilt != 0)
        {
            transform.Rotate(transform.right, tilt * Time.deltaTime * 10, Space.World);
        }
        if (roll != 0)
        {
            transform.Rotate(transform.forward, roll * Time.deltaTime * 10, Space.World);
        }

        rb.AddForce(transform.forward * Time.deltaTime * 10);

        //Gravity
        rb.velocity -= Vector3.up * Time.deltaTime;

        //Eje vertical
        Vector3 vertVel = rb.velocity - Vector3.ProjectOnPlane(rb.velocity, transform.up);
        fall = vertVel.magnitude;
        rb.velocity -= vertVel * Time.deltaTime;
        rb.velocity += vertVel.magnitude * transform.forward * Time.deltaTime / 10;

        //Drag frontal
        Vector3 forwardDrag = rb.velocity - Vector3.ProjectOnPlane(rb.velocity, transform.forward);
        rb.AddForce(-forwardDrag * forwardDrag.magnitude * Time.deltaTime / 1000);

        //Drag lateral
        Vector3 sideDrag = rb.velocity - Vector3.ProjectOnPlane(rb.velocity, transform.right);
        rb.AddForce(-sideDrag * sideDrag.magnitude * Time.deltaTime);

        airSpeed = rb.velocity.magnitude;
    }
    public override void JumpAction(InputAction.CallbackContext cxt)
    {
        rb.AddForce(transform.up * Mathf.Sqrt(wingBeatHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
    }
}
