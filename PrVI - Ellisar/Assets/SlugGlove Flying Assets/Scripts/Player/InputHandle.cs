using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandle : MonoBehaviour
{
    private PlayerMovement Player;

    public float Horizontal;
    public float Vertical;

    public bool Jump;
    public bool JumpHold;

    public bool Accelerate;

    public bool LB;
    public bool RB;

    public bool Fly;

    private bool flightYInverted = false;
    private bool auxYInv = false;

    public bool AuxYInv { set => auxYInv = value; }
    public bool FlightYInverted { get => flightYInverted; set => flightYInverted = value; }

    private void Start()
    {
        Player = GetComponent<PlayerMovement>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Horizontal = Input.GetAxis("Horizontal");
        //Vertical = Input.GetAxis("Vertical");

        //Jump = Input.GetButtonDown("Jump");
        //JumpHold = Input.GetButton("Jump");
        //Fly = JumpHold; 

        //RB = Input.GetButton("RightTilt");
        //LB = Input.GetButton("LeftTilt");

    }
    public void MoveInput(InputAction.CallbackContext cxt)
    {
        Horizontal = cxt.ReadValue<Vector2>().x;
        int i = auxYInv ? -1 : 1;
        Vertical = cxt.ReadValue<Vector2>().y * i;
    }
    public void InvertYOnFlight(InputAction.CallbackContext cxt)
    {
        flightYInverted = !flightYInverted;
    }
    public void InvertYOnFlight_UI(bool active)
    {
        flightYInverted = active;
    }
    public void ChangeIntoFlight(InputAction.CallbackContext cxt)
    {
        if (cxt.performed)
        {
            Fly = true;
            if (flightYInverted)
                auxYInv = true;
        }
    }
    public void ExitGame(InputAction.CallbackContext cxt)
    {
#if UNITY_EDITOR
        if (cxt.started)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
#endif
        if (cxt.performed)
        {
#if UNITY_EDITOR
            Debug.Break();
            return;
#endif
            Application.Quit();
        }
    }
}
