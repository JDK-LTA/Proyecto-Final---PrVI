using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TEMP_CamYInverter : MonoBehaviour
{
    [SerializeField] Cinemachine.CinemachineFreeLook cm;

    public void InvertY(InputAction.CallbackContext cxt)
    {
        if (cxt.performed)
        {
            cm.m_YAxis.m_InvertInput = !cm.m_YAxis.m_InvertInput;
        }
    }

    public void InvertY_UI(bool action)
    {
         cm.m_YAxis.m_InvertInput = action;
    }
    public void MoreSensibility(InputAction.CallbackContext cxt)
    {
        if (cxt.performed)
        {
            cm.m_XAxis.m_MaxSpeed += 10;
            cm.m_YAxis.m_MaxSpeed += 0.05f;
        }
    }
    public void LessSensibility(InputAction.CallbackContext cxt)
    {
        if (cxt.performed)
        {
            if (cm.m_XAxis.m_MaxSpeed > 10)
                cm.m_XAxis.m_MaxSpeed -= 10;
            if (cm.m_YAxis.m_MaxSpeed > 0.05)
                cm.m_YAxis.m_MaxSpeed -= 0.05f;
        }
    }
}
