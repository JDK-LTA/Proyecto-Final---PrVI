using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMM_PlaneMove : PlayerBase, IMovementModifier
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

    [Header("Animation")]
    [SerializeField] private ParticleSystem windEffect;

    [Header("Audio Effects")]
    [SerializeField] private AudioSource audioSource;

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

    public delegate void FallingEvent();
    public event FallingEvent FallenGround;
    public event FallingEvent FallenWater;

    private List<float> defaultValues = new List<float>();

    public float OriginalVel { set => originalVel = value; }
    public ParticleSystem WindEffect { get => windEffect; set => windEffect = value; }

    public Vector3 ApplyMovement(Vector3 value)
    {
        moveVector = transform.forward * DragCalculation();


        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        float inputVertical = Input.GetAxisRaw("Vertical");
        int inverter = invertYAxis ? 1 : -1;
        Vector3 yaw = inputHorizontal * Vector3.up * rotSpeedX * Time.deltaTime;
        Vector3 pitch = inputVertical * Vector3.right * inverter * rotSpeedY * Time.deltaTime;

        transform.Rotate(yaw, Space.World);

        ModelRotation(inputHorizontal);

        float rotX = transform.rotation.eulerAngles.x;
        if (inputVertical * inverter > 0)
        {
            if (!(rotX < 90 && rotX > yMaxAngle))
            {
                transform.Rotate(pitch, Space.Self);
            }
        }
        else
        {
            if (!(rotX > 270 && rotX < 360 - yMaxAngle))
            {
                transform.Rotate(pitch, Space.Self);
            }
        }

        GravityEffect();

        moveMagnitude = moveVector.magnitude;
        value = moveVector;

        CheckGround();

        return value;
    }

    private void ModelRotation(float inputHorizontal)
    {
        float zAxis = planeModelGO.transform.localEulerAngles.z;
        if (inputHorizontal != 0)
        {
            planeRotationZ = zAxis + speedOfVisualRotation * -inputHorizontal * Time.deltaTime;
            if (planeRotationZ > maxPlaneZRotation && planeRotationZ < 270f)
            {
                planeRotationZ = maxPlaneZRotation;
            }
            else if (planeRotationZ < 360f - maxPlaneZRotation && planeRotationZ > 90)
            {
                planeRotationZ = 360f - maxPlaneZRotation;
            }

            planeModelGO.transform.localEulerAngles = new Vector3(0, 0, planeRotationZ);
        }
        else
        {
            if (zAxis < 270 && zAxis > 5)
            {
                planeModelGO.transform.localEulerAngles = new Vector3(0, 0, zAxis - speedOfVisualRotation * Time.deltaTime);
            }
            else if (zAxis > 90 && zAxis < 355)
            {
                planeModelGO.transform.localEulerAngles = new Vector3(0, 0, zAxis + speedOfVisualRotation * Time.deltaTime);
            }
            else if (zAxis > 355 || zAxis < 5)
            {
                planeModelGO.transform.localEulerAngles = Vector3.zero;
            }
        }
    }

    public void OnDisable()
    {
        windEffect.Stop();

        audioSource.Stop();
        audioSource.loop = false;

        handler.RemoveModifier(this);
    }

    public void OnEnable()
    {
        liftPower = 1;
        forwardSpeed = originalVel;
        accelerating = true;
        planeModelGO.transform.localEulerAngles = Vector3.zero;
        
        handler.AddModifier(this);

        if (SoundManager.Instance != null)
        {
            SoundManager.Instance.GetSoundEffect(SoundEffect.PlayerPlaneWind, audioSource);
            audioSource.loop = true;
            audioSource.Play();
        }

        windEffect.Play();
    }

    private void SpeedAccelerator()
    {
        if (accelerating)
        {
            accT += Time.deltaTime;

            forwardSpeed = Mathf.Lerp(originalVel, cruiseForwardSpeed, accT / accTimer);
            dragConstant = forwardSpeed;

            if (accT >= accTimer)
            {
                accelerating = false;
                accT = 0;
                forwardSpeed = cruiseForwardSpeed;
                dragConstant = forwardSpeed;
            }
        }
    }
    private void Start()
    {
        forwardSpeed = cruiseForwardSpeed;
        accTimer = cruiseForwardSpeed / originalVel;

        actualRot = transform.rotation.eulerAngles.x > 180 ? -360 + transform.rotation.eulerAngles.x : transform.rotation.eulerAngles.x;
        anglePerTwo = (actualRot * -1 + 90) / 90;
    }

    private void Update()
    {
        SpeedAccelerator();
    }

    private void GravityEffect()
    {
        moveVector.y += LiftCalculation();
    }


    private float LiftCalculation()
    {
        actualRot = transform.rotation.eulerAngles.x > 180 ? -360 + transform.rotation.eulerAngles.x : transform.rotation.eulerAngles.x;

        anglePerTwo = (actualRot * -1 + 90) / 90; //[0,2]
        float anglePerOne = actualRot / 90; //[-1,1]

        //________________________________________________________________________________________________________________________________________________________//

        if (anglePerOne > 0 && anglePerTwo * liftConstant * liftPower < liftConstant || anglePerOne < 0)
        {
            liftPower += 1 * anglePerOne * Time.deltaTime;
        }
        else if (anglePerOne > 0 && anglePerTwo * liftConstant * liftPower > liftConstant)
        {
            liftPower -= anglePerOne * Time.deltaTime;
        }
        //________________________________________________________________________________________________________________________________________________________//


        liftPower = Mathf.Clamp(liftPower, 0, 2);

        if (anglePerTwo == 2)
        {
            anglePerTwo = 0;
        }

        liftCoefficient = anglePerTwo * liftConstant * liftPower;

        netYForce = handler.Gravity + liftCoefficient;

        //SUBIR -> |GRAVITY| < LC; LC++ -> LIFTPOWER

        return netYForce;
        //LIFT = Coefficient (angle[-1,1] * constant)
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

    private void CheckGround()
    {
        handler.IsGrounded = RayCasting(handler.PlaneCheckers, groundDistance, groundMask);

        if (handler.IsGrounded)
        {
            FallenGround?.Invoke();
        }
        if (RayCasting(handler.PlaneCheckers, waterDistance, waterMask))
        {
            FallenWater?.Invoke();
        }
    }
}
