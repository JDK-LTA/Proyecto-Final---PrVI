using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsImageSwapper : MonoBehaviour
{
    [SerializeField] private Sprite gamepadControls, keyboardControls;
    private UnityEngine.UI.Image image;

    private void Awake()
    {
        //if (UnityEngine.InputSystem.InputDevice. == "Gamepad")
        //{
        //    image.sprite = gamepadControls;
        //}
        //else
        //{
        //    image.sprite = keyboardControls;
        //}
    }

    private void Start()
    {
        image = GetComponent<UnityEngine.UI.Image>();
    }

    public void ChangeControlsText(UnityEngine.InputSystem.PlayerInput input)
    {
        if (input.currentControlScheme == "Gamepad")
        {
            image.sprite = gamepadControls;
        }
        else
        {
            image.sprite = keyboardControls;
        }
    }
}
