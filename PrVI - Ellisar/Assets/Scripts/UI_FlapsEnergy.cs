using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_FlapsEnergy : Singleton<UI_FlapsEnergy>
{
    [SerializeField] private Image feather;
    [SerializeField] private Text featherText, energyText;
    private int energyTotal = 0;

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
