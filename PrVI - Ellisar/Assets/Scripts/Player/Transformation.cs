using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Transformation : PlayerParent
{
    protected static bool isGrounded;
    [SerializeField] protected Vector2 moveInputVector;
    [SerializeField] protected Vector2 lookInputVector;
    public Vector2 MoveInputVector { get => moveInputVector; }
    public Vector2 LookInputVector { get => lookInputVector; }

    public void MoveAction(InputAction.CallbackContext cxt)
    {
        moveInputVector = cxt.ReadValue<Vector2>();
    }
    public void LookAction(InputAction.CallbackContext cxt)
    {
        lookInputVector = cxt.ReadValue<Vector2>();
    }
    public virtual void JumpAction(InputAction.CallbackContext cxt)
    {
    }

}
