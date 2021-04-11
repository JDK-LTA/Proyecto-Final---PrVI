using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class FlightTransformation : Transformation
{
    [SerializeField] protected float wingBeatHeight = 3f;
    [SerializeField] private float energy = 0, fall = 0, airSpeed = 0;

    private DetectCollision colliderDetector;

    private float delta;

    [Header("Physics")]
    [SerializeField] private float handleReturnSpeed; //how quickly our handle on our character is returned to normal after a force is added (such as jumping
    private float actGravAmt; //the actual gravity that is applied to our character
    [SerializeField] private LayerMask groundLayers; //what layers the ground can be
    private float floorTimer; //how long we are on the floor
    private bool onGround;  //the bool for if we are on ground (this is used for the animator
    private float actionAirTimer; //the air timer counting our current actions performed in air

    [Header("Stats")]
    [SerializeField] private float maxSpeed = 15f; //max speed for basic movement
    [SerializeField] private float speedClamp = 50f; //max possible speed
    private float actAccel; //our actual acceleration
    [SerializeField] private float acceleration = 4f; //how quickly we build speed
    [SerializeField] private float movementAcceleration = 20f;    //how quickly we adjust to new speeds
    [SerializeField] private float slowDownAcceleration = 2f; //how quickly we slow down
    [SerializeField] private float turnSpeed = 2f; //how quickly we turn on the ground
    private float flownAdjustmentLerp = 1; //if we have flown this will be reset at 0, and effect turn speed on the ground
    [HideInInspector]
    public float actSpeed; //our actual speed
    private Vector3 movepos, targetDir, DownwardDirection; //where to move to

    [Header("Falling")]
    [SerializeField] private float AirAcceleration = 5f;  //how quickly we adjust to new speeds when in air
    [SerializeField] private float turnSpeedInAir = 2f;
    [SerializeField] private float FallingDirectionSpeed = 0.5f; //how quickly we will return to a normal direction

    [Header("Flying")]
    [SerializeField] private float flyingDirectionSpeed = 2f; //how much influence our direction relative to the camera will influence our flying
    [SerializeField] private float flyingRotationSpeed = 6f; //how fast we turn in air overall
    [SerializeField] private float flyingUpDownSpeed = 0.1f; //how fast we rotate up and down
    [SerializeField] private float flyingLeftRightSpeed = 0.1f;  //how fast we rotate left and right
    [SerializeField] private float flyingRollSpeed = 0.1f; //how fast we roll

    [SerializeField] private float flyingAcceleration = 4f; //how much we accelerate to max speed
    [SerializeField] private float flyingDecelleration = 1f; //how quickly we slow down when flying
    [SerializeField] private float flyingSpeed; //our max flying speed
    [SerializeField] private float flyingMinSpeed; //our flying slow down speed

    [SerializeField] private float flyingAdjustmentSpeed; //how quickly our velocity adjusts to the flying speed
    private float flyingAdjustmentLerp = 0; //the lerp for our adjustment amount

    [Header("Flying Physics")]
    [SerializeField] private float flyingGravity = 2f;
    [SerializeField] private float glideGravity = 4f;
    [SerializeField] private float flyingGravityBuildSpeed = 3f;
    [SerializeField] private float flyingVelGain = 2f;
    [SerializeField] private float flyingVelLoss = 1f;
    [SerializeField] private float flyingLowLimit = -6f;
    [SerializeField] private float flyingUpLimit = 4f;
    [SerializeField] private float glideTime = 10f;

    [Header("Wall Impact")]
    [SerializeField] private float speedLimitBeforeCrash; //how fast we have to be going to crash
    [SerializeField] private float stunPushBack;  //how much we are pushed back
    [SerializeField] private float stunnedTime; //how long we are stunned for
    private float stunTimer; //the in use stun timer

    [Header("Collision detection")]
    [SerializeField] private float bottomOffset;
    [SerializeField] private float frontOffset;
    [SerializeField] private float collisionRadius;
    [SerializeField] private LayerMask GroundLayer;
    [SerializeField] private float WallDistance;

    //check if there is a floor to stand on, or land on
    public bool CheckGround()
    {
        Vector3 Pos = transform.position + (-transform.up * bottomOffset);
        Collider[] hitColliders = Physics.OverlapSphere(Pos, collisionRadius, GroundLayer);
        if (hitColliders.Length > 0)
        {
            //we are on the ground
            return true;
        }

        return false;
    }
    //check if there is a wall to crash into
    public bool CheckWall()
    {
        Vector3 Pos2 = transform.position + (transform.forward * frontOffset);
        Collider[] hitColliders = Physics.OverlapSphere(Pos2, collisionRadius, GroundLayer);

        if (hitColliders.Length > 0)
        {
            return true;
        }

        return false;
    }


    private void Update()
    {
        //energy = transform.position.y + rb.velocity.magnitude;
        //transform.position = rb.position;

        if (CheckWall())
        {
            if (actSpeed > speedLimitBeforeCrash)
            {
                //STUN
                return;
            }
        }
        if (CheckGround())
        {
            //SET GROUNDED
            return;
        }
    }
    private void FixedUpdate()
    {
        //Vector3 yaw = moveInputVector.y * Vector3.up * 
    }

    private void OnEnable()
    {
        actionAirTimer = 0.2f;
        flownAdjustmentLerp = -1;
        rb.useGravity = false;
    }
    private void OnDisable()
    {
        rb.useGravity = true;
    }


    private void OriginalGlider()
    {
        float roll = -moveInputVector.x;
        float tilt = moveInputVector.y;

        if (tilt != 0)
        {
            transform.Rotate(transform.right, tilt * Time.deltaTime * 10, Space.World);
        }
        if (roll != 0)
        {
            transform.Rotate(transform.forward, roll * Time.deltaTime * 10, Space.World);
            transform.Rotate(Vector3.up, -roll * Time.deltaTime * 15, Space.World);
        }

        rb.AddForce(transform.forward * Time.deltaTime * 10);

        //Gravity
        rb.velocity -= Vector3.up * Time.deltaTime;

        //Eje vertical
        Vector3 vertVel = rb.velocity - Vector3.ProjectOnPlane(rb.velocity, transform.up);
        fall = vertVel.magnitude;
        rb.velocity -= vertVel * Time.deltaTime;
        rb.velocity += vertVel.magnitude * transform.forward * Time.deltaTime / 10;

        //Drag frontal
        Vector3 forwardDrag = rb.velocity - Vector3.ProjectOnPlane(rb.velocity, transform.forward);
        rb.AddForce(-forwardDrag * forwardDrag.magnitude * Time.deltaTime / 1000);

        //Drag lateral
        Vector3 sideDrag = rb.velocity - Vector3.ProjectOnPlane(rb.velocity, transform.right);
        rb.AddForce(-sideDrag * sideDrag.magnitude * Time.deltaTime);

        airSpeed = rb.velocity.magnitude;
    }
    public override void JumpAction(InputAction.CallbackContext cxt)
    {
        rb.AddForce(transform.up * Mathf.Sqrt(wingBeatHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
    }
}
