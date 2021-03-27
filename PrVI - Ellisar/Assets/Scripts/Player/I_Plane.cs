
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_Plane : Transformation, IMovementModifier
{
    [Header("Plane Model Visual Rotation")]
    [SerializeField] private GameObject planeModelGO;
    [SerializeField] private float maxPlaneZRotation;
    [SerializeField] private float speedOfVisualRotation = 80f;
    private float planeRotationZ = 0;

    [Header("Plane Movement Settings")]
    [SerializeField] private float cruiseForwardSpeed = 10f;
    private float forwardSpeed;
    [SerializeField] private float rotSpeedX = 3f;
    [SerializeField] private float rotSpeedY = 1.5f;
    [SerializeField] private bool invertYAxis = true;
    [SerializeField] private float yMaxAngle = 70;

    private float liftConstant = 9f;
    private float dragConstant = 3f;

    [Header("Ground checker variables")]
    [SerializeField] private float groundDistance = 0.4f;
    [SerializeField] private float waterDistance = 0.4f;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private LayerMask waterMask;

    [Header("Debug")]
    [SerializeField] private Vector3 moveVector;
    [SerializeField] private float moveMagnitude;

    private float actualRot;
    private float anglePerTwo;
    private float netYForce;
    private float liftPower = 1;
    private float liftCoefficient;

    private bool accelerating = false;
    private float accTimer;
    private float accT = 0;
    private float originalVel = 6f;

    public float OriginalVel { set => originalVel = value; }

    public Vector3 ApplyMovement(Vector3 value)
    {
        moveVector = transform.forward * DragCalculation();
        return moveVector;
    }

    public void OnDisable()
    {
        throw new System.NotImplementedException();
    }

    public void OnEnable()
    {
        throw new System.NotImplementedException();
    }
    private float DragCalculation()
    {
        float actualRot = transform.rotation.eulerAngles.x > 180 ? 360 - transform.rotation.eulerAngles.x : transform.rotation.eulerAngles.x;

        float anglePerOne = actualRot / 90;
        float dragCoefficient = anglePerOne * dragConstant;

        float netXForce = forwardSpeed * liftPower - dragCoefficient;

        return netXForce;
        //DRAG = Coefficient (angle[0,1] * constant)
    }
}
