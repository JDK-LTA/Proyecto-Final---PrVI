using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[System.Serializable]
public enum InitialTransformation { BIPED, FLIGHT }
public class MovHandler : PlayerParent
{
    [SerializeField] private InitialTransformation initialTransformation = InitialTransformation.BIPED;
    [SerializeField] private float bipedMass, bipedDrag, bipedAngDrag, flightMass, flightDrag, flightAngDrag;
    private PlayerInput playerInput;
    private List<Transformation> transformationsList = new List<Transformation>();

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        transformationsList.Add(GetComponent<BipedTransformation>());
        transformationsList.Add(GetComponent<FlightTransformation>());

        switch (initialTransformation)
        {
            case InitialTransformation.BIPED:
                ChangeIntoTransformation(0);
                break;
            case InitialTransformation.FLIGHT:
                ChangeIntoTransformation(1);
                break;
            default:
                ChangeIntoTransformation(0);
                break;
        }
    }

    public void ChangeIntoTransformation(int index)
    {
        foreach (Transformation trans in transformationsList)
        {
            trans.enabled = false;
        }

        transformationsList[index].enabled = true;
    }
    public void ChangeToBiped(InputAction.CallbackContext cxt)
    {
        ChangeIntoTransformation(0);
        playerInput.SwitchCurrentActionMap("PlayerBiped");
    }
    public void ChangeToFlight(InputAction.CallbackContext cxt)
    {
        ChangeIntoTransformation(1);
        rb.useGravity = false;
        playerInput.SwitchCurrentActionMap("PlayerFlight");
    }
}