using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHotfixYPivot : MonoBehaviour
{
    [SerializeField] private Transform camTransform;
    private void Awake()
    {
        camTransform = Camera.main.transform;
    }
    private void Update()
    {
        Vector3 justY = new Vector3(0, camTransform.eulerAngles.y, 0);
        transform.eulerAngles = justY;
    }
}
