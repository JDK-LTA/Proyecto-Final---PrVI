using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitAround : MonoBehaviour
{
    [SerializeField] private Transform objectToOrbitAround;
    [SerializeField] private Vector3 orbitAxis = Vector3.up;
    [SerializeField] private bool customRadius = false;
    [SerializeField] private float orbitRadius = 75f;
    [SerializeField] private float orbitRadiusCorrectionSpeed = 0.5f;
    [SerializeField] private float orbitRotationSpeed = 10f;
    [SerializeField] private float orbitAllignToDirecionSpeed = 0.5f;

    private Vector3 orbitDesiredPosition;
    private Vector3 previousPosition;
    private Vector3 relativePos;
    private Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        if (!customRadius)
            orbitRadius = Vector3.Distance(transform.position, objectToOrbitAround.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (objectToOrbitAround)
        {
            transform.RotateAround(objectToOrbitAround.position, orbitAxis, orbitRotationSpeed * Time.deltaTime);
            orbitDesiredPosition = (transform.position - objectToOrbitAround.position).normalized * orbitRadius + objectToOrbitAround.position;
            transform.position = Vector3.Slerp(transform.position, orbitDesiredPosition, Time.deltaTime * orbitRadiusCorrectionSpeed);

            relativePos = transform.position - previousPosition;
            rotation = Quaternion.LookRotation(relativePos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, orbitAllignToDirecionSpeed * Time.deltaTime);
            previousPosition = transform.position;
        }
    }
}
