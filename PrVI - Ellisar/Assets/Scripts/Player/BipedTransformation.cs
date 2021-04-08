using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BipedTransformation : Transformation
{
    [SerializeField] private float walkingSpeed = 5f, rotatingSpeed = 5f;

    [SerializeField] private float jumpForce;
    [SerializeField] private ForceMode jumpForceMode = ForceMode.Impulse;
    [SerializeField] private bool isJumping;

    [SerializeField] private float hookForce;
    [SerializeField] private ForceMode hookForceMode = ForceMode.VelocityChange;
    [SerializeField] private bool canHook = true;
    [SerializeField] private Vector3 targetHookPos = Vector3.up * 100000;
    [SerializeField] private float hookCooldown = 1f;
    private float tHook = 0;

    [SerializeField] private float currentSpeed;

    private List<HookOption> hookOptions = new List<HookOption>();

    public List<HookOption> HookOptions { get => hookOptions; set => hookOptions = value; }

    private void Update()
    {
        UpdateHookTarget();
        if (!canHook)
        {
            tHook += Time.deltaTime;
            if (tHook >= hookCooldown)
            {
                canHook = true;
                tHook = 0;
            }
        }
        currentSpeed = rb.velocity.magnitude;
    }

    private void UpdateHookTarget()
    {
        if (hookOptions.Count > 1)
        {
            foreach (HookOption hook in hookOptions)
            {
                if (Vector3.Distance(hook.transform.position, transform.position) < Vector3.Distance(targetHookPos, transform.position))
                {
                    targetHookPos = hook.transform.position;
                }
            }
        }
        else if (hookOptions.Count == 1)
        {
            targetHookPos = hookOptions[0].transform.position;
        }
        else
        {
            targetHookPos = Vector3.up * 100000;
        }
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
            rb.AddForce(jumpForce * Vector3.up, jumpForceMode);
        }
    }
    public override void RTriggerAction(InputAction.CallbackContext cxt)
    {
        if (canHook)
        {
            rb.AddForce((targetHookPos - transform.position) * hookForce, hookForceMode);
            canHook = false;
        }
    }
}
