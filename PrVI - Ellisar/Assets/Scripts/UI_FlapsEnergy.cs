using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class UI_FlapsEnergy : Singleton<UI_FlapsEnergy>
{
    [SerializeField] private Image feather;
    [SerializeField] private Text featherText, energyText;
    [SerializeField] private GameObject controlsPanel;
    private Text controlsText;
    private int energyTotal = 0;

    private static string gamepadText = "Controls:\nLeft Joystick - Movement\nRight Joystick - Camera\nX - Jump(if biped)\nR2 - Hook(biped) / Flap wings / Bomb forward\nL2 - Bomb down(ball)\nL1 + X - Biped mode\nL1 + ▲ - Flight mode\nL1 + ◯ - Ball mode\nR3 (hold) - Respawn\nUp Arrow - Invert Camera Y Axis\nDown Arrow - Invert Y Flight Movement\n<- + -> Arrows - More/Less Cam Sensibility";
    private static string keyboardText = "Controls:\nWASD - Movement\nMouse - Camera\nSpace - Jump (biped)\nQ - Hook(biped) / Flap wings / Bomb forward\nE - Bomb down(ball)\n1 - Biped mode\n2 - Flight mode\n3 - Ball mode\nR (hold) - Respawn\nY - Invert Camera Y Axis\nU - Invert Y Flight Movement\n, and . - More/Less Cam Sensibility";

    private void Start()
    {
        controlsText = controlsPanel.GetComponentInChildren<Text>();
    }
    public void ToggleShowControls(InputAction.CallbackContext cxt)
    {
        if (cxt.performed)
        {
            controlsPanel.SetActive(!controlsPanel.activeInHierarchy);
        }
    }
    public void ChangeControlsText(PlayerInput input)
    {
        if (input.currentControlScheme == "Gamepad")
        {
            controlsText.text = gamepadText;
        }
        else
        {
            controlsText.text = keyboardText;
        }
    }
    public void UpdateFeatherText(int amount)
    {
        featherText.text = amount.ToString();
    }
    public void UpdateEnergyText(int amount)
    {
        energyText.text = amount.ToString();
    }
    public void SumEnergy()
    {
        energyTotal++;
        UpdateEnergyText(energyTotal);
    }
    public void UpdateFeatherImage(float fill)
    {
        feather.fillAmount = fill;
    }
}
