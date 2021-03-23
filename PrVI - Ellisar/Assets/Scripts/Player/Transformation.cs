using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Transformation : PlayerParent
{
    protected static bool isGrounded;
    public Vector2 moveInputVector;
    public Vector2 lookInputVector;
    public Vector2 MoveVector { get => moveInputVector; }
    public Vector2 LookInputVector { get => lookInputVector; }

    public void MoveAction(InputAction.CallbackContext cxt)
    {
        moveInputVector = cxt.ReadValue<Vector2>();
    }
    public void LookAction(InputAction.CallbackContext cxt)
    {
        lookInputVector = cxt.ReadValue<Vector2>();
    }
}
