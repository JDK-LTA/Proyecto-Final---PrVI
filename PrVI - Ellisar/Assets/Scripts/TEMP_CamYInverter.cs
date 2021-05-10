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
}
