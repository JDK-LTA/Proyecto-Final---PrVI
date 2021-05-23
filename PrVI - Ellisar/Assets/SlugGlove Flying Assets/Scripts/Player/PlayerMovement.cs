using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [System.Serializable]
    public enum WorldState
    {
        Grounded, //on ground
        InAir, //in the air
        Flying, //trying to fly
        Stunned, //on a wall
        Static,
    }

    //[HideInInspector]
    public WorldState States;
    private Transform Cam; //reference to our camera
    private Transform CamY; //reference to our camera axis
    private CameraFollow CamFol; //reference to our camera script
    private PlayerVisuals Visuals; //script for handling visual effects
    private Vector3 CheckPointPos; //where we respawn
    private Collider parentOwnCollider, rigidCollider;

    private DetectCollision Colli; //collision detection
    [HideInInspector]
    public Rigidbody Rigid; //rigidbody 
    private Animator Anim; //animator
    private InputHandle InputHand; //script for handling our inputs

    float delta;

    [Header("Physics")]
    [SerializeField] private PhysicMaterial bipedPhysMat;
    [SerializeField] private PhysicMaterial flightPhysMat;
    [SerializeField] private PhysicMaterial ballPhysMat;
    [SerializeField] private float HandleReturnSpeed; //how quickly our handle on our character is returned to normal after a force is added (such as jumping
    private float ActGravAmt; //the actual gravity that is applied to our character
    [SerializeField] private LayerMask GroundLayers; //what layers the ground can be
    private float FloorTimer; //how long we are on the floor
    private bool OnGround;  //the bool for if we are on ground (this is used for the animator
    private float ActionAirTimer; //the air timer counting our current actions performed in air

    [Header("Biped Stats")]
    [SerializeField] private float MaxSpeed = 15f; //max speed for basic movement
    [SerializeField] private float SpeedClamp = 50f; //max possible speed
    private float ActAccel; //our actual acceleration
    [SerializeField] private float Acceleration = 4f; //how quickly we build speed
    [SerializeField] private float MovementAcceleration = 20f;    //how quickly we adjust to new speeds
    [SerializeField] private float SlowDownAcceleration = 2f; //how quickly we slow down
    [SerializeField] private float turnSpeed = 2f; //how quickly we turn on the ground
    [SerializeField] private float bipedSnapMult = 1;
    private float FlownAdjustmentLerp = 1; //if we have flown this will be reset at 0, and effect turn speed on the ground
    [HideInInspector]
    public float ActSpeed; //our actual speed
    private Vector3 movepos, targetDir, DownwardDirection; //where to move to

    [Header("Falling")]
    [SerializeField] private float AirAcceleration = 5f;  //how quickly we adjust to new speeds when in air
    [SerializeField] private float turnSpeedInAir = 2f;
    [SerializeField] private float FallingDirectionSpeed = 0.5f; //how quickly we will return to a normal direction

    [Header("Flying")]
    [SerializeField] private bool yInvertedOnFlight = true;
    [SerializeField] private float FlyingDirectionSpeed = 2f; //how much influence our direction relative to the camera will influence our flying
    [SerializeField] private float FlyingRotationSpeed = 6f; //how fast we turn in air overall
    [SerializeField] private float FlyingUpDownSpeed = 0.1f; //how fast we rotate up and down
    [SerializeField] private float FlyingLeftRightSpeed = 0.1f;  //how fast we rotate left and right
    [SerializeField] private float FlyingRollSpeed = 0.1f; //how fast we roll

    [SerializeField] private float FlyingAcceleration = 4f; //how much we accelerate to max speed
    [SerializeField] private float FlyingDecelleration = 1f; //how quickly we slow down when flying
    [SerializeField] private float FlyingSpeed; //our max flying speed
    [SerializeField] private float FlyingMinSpeed; //our flying slow down speed

    [SerializeField] private float FlyingAdjustmentSpeed; //how quickly our velocity adjusts to the flying speed
    private float FlyingAdjustmentLerp = 0; //the lerp for our adjustment amount

    [Header("Flying Physics")]
    [SerializeField] private float FlyingGravityAmt = 2f; //how much gravity will pull us down when flying
    [SerializeField] private float GlideGravityAmt = 4f; //how much gravity affects us when just gliding
    [SerializeField] private float FlyingGravBuildSpeed = 3f; //how much our gravity is lerped when stopping flying

    [SerializeField] private float FlyingVelocityGain = 2f; //how much velocity we gain for flying downwards
    [SerializeField] private float FlyingVelocityLoss = 1f; //how much velocity we lose for flying upwards
    [SerializeField] private float FlyingLowerLimit = -6f; //how much we fly down before a boost
    [SerializeField] private float FlyingUpperLimit = 4f; //how much we fly up before a boost;
    [SerializeField] private float GlideTime = 10f; //how long we glide for when not flying before we start to fall

    [Header("Jumps")]
    [SerializeField] private float JumpAmt; //how much we jump upwards 
    private bool HasJumped; //if we have pressed jump
    [SerializeField] private float GroundedTimerBeforeJump = 0.2f; //how long we have to be on the floor before an action can be made
    [SerializeField] private float JumpForwardAmount = 5f; //how much our regular jumps move us forward

    [Header("Wall Impact")]
    [SerializeField] private float SpeedLimitBeforeCrash; //how fast we have to be going to crash
    [SerializeField] private float StunPushBack;  //how much we are pushed back
    [SerializeField] private float StunnedTime; //how long we are stunned for
    private float StunTimer; //the in use stun timer

    [Header("Visuals")]
    private Transform HipsPos; //where our characters hips are
    private bool MirrorAnim; //if anims should be mirroed
    private float XAnimFloat; //the float for our wing turning
    private float RunTimer; //animation ctrl for running
    private float FlyingTimer; //the time before the animation stops flying


    [Header("Flap")]
    [SerializeField] private int maxNOfFlaps = 4;
    private int actualFlaps = 0;
    [SerializeField] private float cooldownToRegenFlap = 6;
    private float tCdInterFlap = 0;

    [SerializeField] private float flapForce = 30;
    private bool hasFlapped = false, flapCd = false;
    [SerializeField] private float flappingTimer = 1f, flappingCooldown = 2f;
    [SerializeField] private float flapRegenFactorWhenBipedGrounded = 12f;
    [SerializeField] private float flapRegenFactorWhenBallGrounded = 5f;
    private float tFlap = 0, tFlapCd = 0;

    private bool isFlying = false;
    private bool startedFlying = false;
    [SerializeField] private float startFlightWindow = 0.4f;
    private float tStartFlight = 0;

    [Header("Hook")]
    [SerializeField] private ForceMode hookForceMode = ForceMode.VelocityChange;
    [SerializeField] private bool canHook = true, hasHooked = false;
    private float hookForce;
    [SerializeField] private List<HookOption> hookOptions = new List<HookOption>();
    private Vector3 targetHookPos;
    [SerializeField] private float hookCooldown = 1f;
    private float tHook = 0;

    [Header("Flash")]
    [SerializeField] private float startingRadius = 1f;
    [SerializeField] private float finalRadius = 15f;
    private float radius;
    [SerializeField] private float timeToFinishFlash = 1f;
    [SerializeField] private float flashCooldown = 8f;
    private bool hasFlashed = false;
    private float tCdFlash = 0;
    private float tFlash = 0;
    private bool flashing = false;
    private Vector3 flashPosition;
    private bool canFlash = true;

    [Header("Ball Stats")]
    [SerializeField] private float bombForce = 15f;
    [SerializeField] private float massWhenBall = 3;
    [SerializeField] private float ballGravAmt = 14;
    [SerializeField] private float ballSnapMult = 0;
    [SerializeField] private float downwardsVelLimitOnBomb = -10;
    [SerializeField] private float ballSpeedToDestroyWalls = 30f;
    [SerializeField] private float ballBoost = 15;
    [SerializeField] private GameObject ballMesh;
    [SerializeField] private float ballModelMaxRotPerSec = 360;
    [SerializeField] private GameObject bodyMesh, faceMesh, ponchoMesh;
    private bool isBombing = false;
    private bool ballActivated = false;
    private float originalMass;

    private Vector3 originalPosition;

    [Header("VFX")]
    [SerializeField] private VFX_Manager vfx_Manager;
    [SerializeField] private ParticleSystem positionMarker;
    [SerializeField] private Transform positionMarkerTransform;
    [SerializeField] private float maxDistanceForMarker = 100;
    [SerializeField] private ParticleSystem speedVFX;
    [Range(0, 200)]
    [SerializeField] private float maxRateOfSpeedVFX = 100;
    [SerializeField] private GameObject model_00;
    [SerializeField] private GameObject model_01;
    [SerializeField] private GameObject model_02;
    private bool isInAir_VFX;

    private NPCDialogTrigger interactableDialog;
    private bool canInteract;


    public List<HookOption> HookOptions { get => hookOptions; set => hookOptions = value; }
    public NPCDialogTrigger InteractableDialog { get => interactableDialog; set => interactableDialog = value; }
    public bool CanInteract { get => canInteract; set => canInteract = value; }

    public void RTriggerAction(InputAction.CallbackContext cxt)
    {
        if (cxt.started)
        {
            if (States == WorldState.Flying && flapCd == false && actualFlaps > 0)
            {
                flapCd = true;
                hasFlapped = true;
                actualFlaps--;
                UI_FlapsEnergy.Instance.UpdateFeatherText(actualFlaps);

                SpeedBoost(flapForce);
            }
            else if (States == WorldState.Grounded || States == WorldState.InAir)
            {
                if (canHook && !hasHooked && !ballActivated)
                {
                    Rigid.velocity = Vector3.zero;
                    Rigid.AddForce((targetHookPos - transform.position).normalized * hookForce, hookForceMode);
                    ActAccel = 0;
                    hasHooked = true;

                    //Animations
                    Anim.SetTrigger("Hook");
                }
                else if (ballActivated && actualFlaps > 0)
                {
                    SpeedBoost(ballBoost);
                    actualFlaps--;
                    UI_FlapsEnergy.Instance.UpdateFeatherText(actualFlaps);
                }
            }
        }
    }
    public void ChangeToBiped(InputAction.CallbackContext cxt)
    {
        if (cxt.performed && ((model_01 != null && model_02 != null) && (model_02.activeInHierarchy || model_01.activeInHierarchy)))
        {
            SetBiped();
        }
    }

    public void SetBiped()
    {
        SetGrounded();
        ballActivated = false;
        Rigid.mass = originalMass;
        isBombing = false;
        canFlash = true;

        //play vfx
        vfx_Manager.PlayParticles(0);

        //change mesh
        model_02.SetActive(false);
        model_01.SetActive(false);
        model_00.SetActive(true);

        //get actual animator
        Anim = GetComponentInChildren<Animator>();

        //ballMesh.SetActive(false);
        //bodyMesh.SetActive(true);
        //faceMesh.SetActive(true);
        //ponchoMesh.SetActive(true);

        parentOwnCollider.material = bipedPhysMat;
        rigidCollider.material = bipedPhysMat;
    }

    public void ChangeToBall(InputAction.CallbackContext cxt)
    {
        if (cxt.performed && (States == WorldState.InAir || States == WorldState.Flying))
        {
            SetBall();
        }
    }
    public void ResetLevel(InputAction.CallbackContext cxt)
    {
        if (cxt.performed)
        {
            Rigid.position = originalPosition;
            Physics.SyncTransforms();
        }
    }
    public void FlashAction(InputAction.CallbackContext cxt)
    {
        if (cxt.performed)
        {
            //ANIMACIÓN DE DESTELLO
            flashPosition = Rigid.position;
            flashing = true;
            hasFlashed = true;
        }
    }
    public void JumpAction(InputAction.CallbackContext cxt)
    {
        if (cxt.started && States == WorldState.Grounded && !ballActivated)
        {
            if (FloorTimer > 0)
                return;

            //check for ground
            bool Ground = Colli.CheckGround();

            if (!Ground)
            {
                SetInAir();
                return;
            }

            RaycastHit hit;
            Physics.Raycast(transform.position + Vector3.up * 1.1f, transform.forward, out hit, 0.7f);

            if (!HasJumped /*&& Vector3.Angle(Vector3.up, hit.normal) < 50*/)
            {
                if (Anim)
                {
                    MirrorAnim = !MirrorAnim;
                    Anim.SetBool("Mirror", MirrorAnim);
                }

                Visuals.Jump();

                float AddAmt = Mathf.Clamp((ActSpeed * 0.5f), -10, 16);
                float ForwardAmt = Mathf.Clamp(ActSpeed * 4f, JumpForwardAmount, 100);

                StopCoroutine(JumpUp(ForwardAmt, JumpAmt + AddAmt));
                StartCoroutine(JumpUp(ForwardAmt, JumpAmt + AddAmt));

                return;
            }
        }
    }
    public void BombPress(InputAction.CallbackContext cxt)
    {
        if (cxt.performed && States == WorldState.InAir && ballActivated)
        {
            isBombing = true;
        }
    }
    public void BombRelease(InputAction.CallbackContext cxt)
    {
        if (cxt.performed && ballActivated)
        {
            isBombing = false;
        }
    }
    public void Interact(InputAction.CallbackContext cxt)
    {
        if (canInteract && interactableDialog)
        {
            interactableDialog.EnableTexter();
        }
    }

    private void Awake()
    {
        //static until finished setup
        States = WorldState.Static;


        InputHand = GetComponent<InputHandle>();
        Colli = GetComponent<DetectCollision>();
        Visuals = GetComponent<PlayerVisuals>();
        HipsPos = Visuals.HipsPos;

        Cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
        CamY = Cam.transform.parent.parent.transform;
        CamFol = Cam.GetComponentInParent<CameraFollow>();

        CheckPointPos = transform.position;

        //setup this characters stats
        SetupCharacter();

        TryGetComponent(out parentOwnCollider);
        Rigid.TryGetComponent(out rigidCollider);

        originalMass = Rigid.mass;
        originalPosition = Rigid.position;

        targetHookPos = Rigid.position;
        actualFlaps = maxNOfFlaps;
        //UI_FlapsEnergy.Instance.UpdateFeatherText(actualFlaps);
    }
    private void Update()   //inputs and animation
    {
        //cannot function when dead
        if (States == WorldState.Static)
            return;

        FlapTimers();
        HookFunctionality();
        StartFlightTimer();
        FlapRegenTimer();
        FlashingTimer();
        FlashCdTimer();

        //control the animator
        AnimCtrl();

        transform.position = Rigid.position;

        if (ballActivated)
            model_02.transform.rotation = Rigid.transform.rotation;

        //check for jumping
        if (States == WorldState.Grounded)
        {
            if (FloorTimer > 0)
                return;

            //check for ground
            bool Ground = Colli.CheckGround();

            if (!Ground)
            {
                SetInAir();
                return;
            }
            else
            {
                //actualFlaps = maxNOfFlaps;
            }
            #region DEP

            //if (InputHand.Jump)
            //{
            //    //if the player can jump, isnt attacking and isnt using an item
            //    if (!HasJumped)
            //    {
            //        if (Anim)
            //        {
            //            MirrorAnim = !MirrorAnim;
            //            Anim.SetBool("Mirror", MirrorAnim);
            //        }

            //        Visuals.Jump();

            //        float AddAmt = Mathf.Clamp((ActSpeed * 0.5f), -10, 16);
            //        float ForwardAmt = Mathf.Clamp(ActSpeed * 4f, JumpForwardAmount, 100);

            //        StopCoroutine(JumpUp(ForwardAmt, JumpAmt + AddAmt));
            //        StartCoroutine(JumpUp(ForwardAmt, JumpAmt + AddAmt));

            //        return;
            //    }
            //}
            #endregion
        }
        else if (States == WorldState.InAir)
        {
            isInAir_VFX = CheckGroundForMarker();

            if (ActionAirTimer > 0) //reduce air timer 
                return;

            if (HasJumped) //cannot switch to flying until jump is done
                return;

            if (InputHand.Fly)  //switch to flying
            {
                SetFlying();
            }


            //check for ground
            bool Ground = Colli.CheckGround();

            if (Ground)
            {
                SetGrounded();
                //actualFlaps = maxNOfFlaps;
                return;
            }
        }
        else if (States == WorldState.Flying)
        {
            if (ActionAirTimer > 0) //reduce air timer 
                return;

            //check wall collision for a crash, if this unit can crash
            bool WallHit = Colli.CheckWall();

            //if we have hit a wall
            if (WallHit)
            {
                //if we are going fast enough to crash into a wall
                if (ActSpeed > SpeedLimitBeforeCrash)
                {
                    //stun character
                    Stunned(-transform.forward);
                    return;
                }
                else
                {
                    SetGrounded();
                    return;
                }
            }

            //check for ground if we are not holding the flying button
            if (!startedFlying)
            {
                bool Ground = Colli.CheckGround();

                if (Ground)
                {
                    SetGrounded();
                    return;
                }
            }
        }

        if ((States == WorldState.Grounded || States == WorldState.InAir) && ballActivated == true)
        {

            Collider hitColl = Colli.CheckBallWall();
            if (hitColl && Rigid.velocity.magnitude > ballSpeedToDestroyWalls)
            {
                Destroy(hitColl.gameObject);
            }
        }
    }


    private void FixedUpdate()
    {
        //tick deltatime
        delta = Time.deltaTime;

        #region DEPRECATED
        //get velocity to feed to the camera
        //float CamVel = 0;
        //if (Rigid != null)
        //    CamVel = Rigid.velocity.magnitude;
        //change the cameras fov based on speed
        //CamFol.HandleFov(delta, CamVel);
        #endregion

        //cannot function when dead
        if (States == WorldState.Static)
        {
            //turn off air sound
            Visuals.WindAudioSetting(delta * 3f, 0f);

            return;
        }
        //tick any fixed camera controls
        FixedAnimCtrl(delta);

        //control our direction slightly when falling
        float _xMov = InputHand.Horizontal;
        float _zMov = InputHand.Vertical;

        //get our direction of input based on camera position
        Vector3 screenMovementForward = CamY.transform.forward;
        Vector3 screenMovementRight = CamY.transform.right;
        Vector3 screenMovementUp = CamY.transform.up;

        Vector3 h = screenMovementRight * _xMov;
        Vector3 v = screenMovementForward * _zMov;

        Vector3 moveDirection = (v + h).normalized;

        if (States == WorldState.Grounded)
        {

            //turn off wind audio
            if (Visuals.WindLerpAmt > 0)
                Visuals.WindAudioSetting(delta * 3f, 0f);

            float LSpeed = MaxSpeed;
            float Accel = Acceleration;
            float MoveAccel = MovementAcceleration;

            //reduce floor timer
            if (FloorTimer > 0)
                FloorTimer -= delta;

            if (InputHand.Horizontal == 0 && InputHand.Vertical == 0)
            {
                //we are not moving, lerp to a walk speed
                LSpeed = 0f;
                Accel = SlowDownAcceleration;
            }
            //lerp our current speed
            if (ActSpeed > LSpeed - 0.5f || ActSpeed < LSpeed + 0.5f)
                LerpSpeed(delta, LSpeed, Accel);
            //move our character
            MoveSelf(delta, ActSpeed, MoveAccel, moveDirection);
        }
        else if (States == WorldState.InAir)
        {

            //reduce air timer 
            if (ActionAirTimer > 0)
                ActionAirTimer -= delta;

            //falling effect
            Visuals.FallEffectCheck(delta);

            //falling audio
            Visuals.WindAudioSetting(delta, Rigid.velocity.magnitude);

            //slow our flying control if we were not
            if (FlyingAdjustmentLerp > -.1)
                FlyingAdjustmentLerp -= delta * (FlyingAdjustmentSpeed * 0.5f);

            if (isBombing && Rigid.velocity.y > downwardsVelLimitOnBomb)
            {
                Rigid.AddForce(Vector3.down * bombForce, ForceMode.Force);
            }

            //control our character when falling
            FallingCtrl(delta, ActSpeed, AirAcceleration, moveDirection);
        }
        else if (States == WorldState.Flying)
        {
            //setup gliding
            if (!hasFlapped)
            {
                if (FlyingTimer > 0) //reduce flying timer 
                    FlyingTimer -= delta;
            }
            else if (FlyingTimer < GlideTime)
            {
                //flapping animation
                if (FlyingTimer < GlideTime * 0.8f)
                    Anim.SetTrigger("Flap");

                FlyingTimer = GlideTime;
            }

            //reduce air timer 
            if (ActionAirTimer > 0)
                ActionAirTimer -= delta;

            //falling effect
            Visuals.FallEffectCheck(delta);

            //falling audio
            Visuals.WindAudioSetting(delta, Rigid.velocity.magnitude);

            //lerp controls
            if (FlyingAdjustmentLerp < 1.1)
                FlyingAdjustmentLerp += delta * FlyingAdjustmentSpeed;

            //lerp speed
            float YAmt = Rigid.velocity.y;
            float FlyAccel;
            float Spd;
            if (!hasFlapped)  //we are not holding fly, slow down
            {
                Spd = FlyingMinSpeed;
                if (ActSpeed > FlyingMinSpeed)
                    FlyAccel = FlyingDecelleration * FlyingAdjustmentLerp;
                else
                    FlyAccel = FlyingAcceleration * FlyingAdjustmentLerp;
            }
            else
            {
                Spd = FlyingSpeed;
                FlyAccel = FlyingAcceleration * FlyingAdjustmentLerp;
                //flying effects 
                Visuals.FlyingFxTimer(delta);
            }

            HandleVelocity(delta, Spd, FlyAccel, YAmt);

            //flying controls
            FlyingCtrl(delta, ActSpeed, _xMov, _zMov);

        }
        else if (States == WorldState.Stunned)
        {
            //reduce stun timer
            if (StunTimer > 0)
            {
                StunTimer -= delta;

                if (StunTimer > StunnedTime * 0.5f)
                    return;
            }


            //switch to air
            bool Ground = Colli.CheckGround();

            //reduce ground timer
            if (Ground)
            {
                if (Anim)
                    Anim.SetBool("Stunned", false);

                //get up from ground
                if (StunTimer <= 0)
                {
                    SetGrounded();
                    return;
                }
            }

            //lerp mesh slower when not on ground
            RotateSelf(DownwardDirection, delta, 8f);
            RotateMesh(delta, transform.forward, turnSpeed);

            //push backwards while we fall
            Vector3 FallDir = -transform.forward * 4f;
            FallDir.y = Rigid.velocity.y;
            Rigid.velocity = Vector3.Lerp(Rigid.velocity, FallDir, delta * 2f);

            //falling audio
            Visuals.WindAudioSetting(delta, Rigid.velocity.magnitude);
        }


        if (speedVFX)
        {
            ParticleSystem.EmissionModule emission = speedVFX.emission;
            emission.rateOverTime = Mathf.Lerp(0, maxRateOfSpeedVFX, ActSpeed / SpeedClamp);
        }
    }


    private bool CheckGroundForMarker()
    {
        RaycastHit hitInfo;
        int layermasking = 1 << 0;

        if (Physics.Raycast(transform.position, Vector3.down, out hitInfo, maxDistanceForMarker, layermasking))
        {
            if (positionMarkerTransform)
            {
                positionMarkerTransform.position = hitInfo.point + new Vector3(0, 0.05f, 0);
                positionMarkerTransform.eulerAngles = hitInfo.normal + new Vector3(90, 0, 0);
            }
            return true;
        }
        else return false;
    }
    private void FlashCdTimer()
    {
        if (hasFlashed)
        {
            tCdFlash += Time.deltaTime;
            if (tCdFlash >= flashCooldown)
            {
                tCdFlash = 0;
                hasFlashed = false;
            }
        }
    }
    private void FlashingTimer()
    {
        if (flashing)
        {
            tFlash += Time.deltaTime;
            radius = Mathf.Lerp(startingRadius, finalRadius, tFlash / timeToFinishFlash);
            Collider[] flashColls = Physics.OverlapSphere(flashPosition, radius);

            foreach (Collider coll in flashColls)
            {
                FlashableWall fl = coll.GetComponent<FlashableWall>();
                fl?.GetFlashed();
            }

            if (tFlash >= timeToFinishFlash)
            {
                tFlash = 0;
                radius = startingRadius;
                flashing = false;
            }
        }
    }
    private void FlapRegenTimer()
    {
        if (actualFlaps < maxNOfFlaps)
        {
            float mult = States == WorldState.Grounded ? (ballActivated ? flapRegenFactorWhenBallGrounded : flapRegenFactorWhenBipedGrounded) : 1;
            tCdInterFlap += Time.deltaTime * mult;

            UI_FlapsEnergy.Instance.UpdateFeatherImage(tCdInterFlap / cooldownToRegenFlap);

            if (tCdInterFlap >= cooldownToRegenFlap)
            {
                tCdInterFlap = 0;
                actualFlaps++;
                UI_FlapsEnergy.Instance.UpdateFeatherText(actualFlaps);
            }
        }
    }
    private void FlapTimers()
    {
        if (hasFlapped)
        {
            tFlap += Time.deltaTime;
            if (tFlap >= flappingTimer)
            {
                tFlap = 0;
                hasFlapped = false;
            }
        }
        if (flapCd)
        {
            tFlapCd += Time.deltaTime;
            if (tFlapCd >= flappingCooldown)
            {
                tFlapCd = 0;
                flapCd = false;
            }
        }
    }
    private void StartFlightTimer()
    {
        if (startedFlying)
        {
            tStartFlight += Time.deltaTime;
            if (tStartFlight >= startFlightWindow)
            {
                startedFlying = false;
                tStartFlight = 0;
            }
        }
    }
    private void HookFunctionality()
    {
        UpdateHookTarget();
        if (hasHooked)
        {
            tHook += Time.deltaTime;
            if (tHook >= hookCooldown)
            {
                hasHooked = false;
                tHook = 0;
            }
        }
    }
    private void UpdateHookTarget()
    {
        if (hookOptions.Count > 1)
        {
            foreach (HookOption hook in hookOptions)
            {
                if (Vector3.Distance(hook.transform.position, transform.position) < Vector3.Distance(targetHookPos, transform.position))
                {
                    targetHookPos = hook.transform.position;
                    hookForce = hook.forceOfHook;
                }
            }
        }
        else if (hookOptions.Count == 1)
        {
            targetHookPos = hookOptions[0].transform.position;
            hookForce = hookOptions[0].forceOfHook;
        }
        else
        {
            targetHookPos = Rigid.position;
            hookForce = 0;
        }
        canHook = hookOptions.Count > 0;
    }
    IEnumerator JumpUp(float ForwardAmt, float UpwardsAmt)
    {
        HasJumped = true;
        //kill velocity
        Rigid.velocity = Vector3.zero;
        //set to in air as we will be 
        SetInAir();
        //add force upwards
        if (UpwardsAmt != 0)
            Rigid.AddForce((Vector3.up * UpwardsAmt), ForceMode.Impulse);
        //add force forwards
        if (ForwardAmt != 0)
            Rigid.AddForce((transform.forward * ForwardAmt), ForceMode.Impulse);
        //remove any built up acceleration
        ActAccel = 0;
        //stop jump state
        yield return new WaitForSecondsRealtime(0.3f);
        HasJumped = false;
    }

    //for when we return to the ground
    public void SetGrounded()
    {
        InputHand.AuxYInv = false;

        Visuals.Landing();
        if (model_01 != null)
        {
            //turn on ground form
            if (model_01.activeInHierarchy)
            {
                //play vfx
                vfx_Manager.PlayParticles(0);
                //change mesh
                model_01.SetActive(false);
                model_02.SetActive(false);
                model_00.SetActive(true);
                positionMarker.gameObject.SetActive(true);

                //get actual animator
                Anim = GetComponentInChildren<Animator>();
            }
        }




        //turn off positionMarker
        if (positionMarker)
            positionMarker.Stop();

        //reset wind animation
        Visuals.SetFallingEffects(1.6f);

        //reset flying animation 
        FlyingTimer = 0;
        //reset flying adjustment
        FlyingAdjustmentLerp = 0;

        //reset physics and jumps
        DownwardDirection = Vector3.up;
        States = WorldState.Grounded; //on ground
        OnGround = true;

        //camera reset flying state
        //CamFol.SetFlyingState(0);

        //turn on gravity
        Rigid.useGravity = false;

        isFlying = false;
        startedFlying = false;
        tStartFlight = 0;
        InputHand.Fly = false;

        //ballActivated = false;
        //Rigid.mass = originalMass;
        //isBombing = false;

        //parentOwnCollider.material = bipedPhysMat;
        //rigidCollider.material = bipedPhysMat;
    }
    //for when we are set in the air (for falling
    private void SetInAir()
    {

        //turn positionMarker On
        if (isInAir_VFX)
        {
            if (positionMarker)
                positionMarker.Play();
        }

        OnGround = false;
        FloorTimer = GroundedTimerBeforeJump;
        ActionAirTimer = 0.2f;

        States = WorldState.InAir;

        //camera reset flying state
        //CamFol.SetFlyingState(0);

        //turn off gravity
        Rigid.useGravity = true;
    }
    //for when we start to fly
    private void SetFlying()
    {
        //play vfx
        vfx_Manager.PlayParticles(1);

        //turn on Air form
        model_00.SetActive(false);
        model_02.SetActive(false);
        model_01.SetActive(true);
        positionMarker.gameObject.SetActive(false);

        //get current animator
        Anim = GetComponentInChildren<Animator>();

        isFlying = true;
        startedFlying = true;
        InputHand.Fly = false;

        States = WorldState.Flying;

        //set animation 
        FlyingTimer = GlideTime;

        ActGravAmt = 0f; //our gravity is returned to the flying amount

        FlownAdjustmentLerp = -1;

        //camera set flying state
        //CamFol.SetFlyingState(1);

        //turn on gravity
        Rigid.useGravity = false;

        ballActivated = false;
        Rigid.mass = originalMass;
        isBombing = false;

        canFlash = false;

        //ballMesh.SetActive(false);
        //bodyMesh.SetActive(true);
        //faceMesh.SetActive(true);
        //ponchoMesh.SetActive(true);

        parentOwnCollider.material = flightPhysMat;
        rigidCollider.material = flightPhysMat;
    }
    public void SetBall()
    {
        InputHand.AuxYInv = false;

        //play vfx
        if (!ballActivated)
            vfx_Manager.PlayParticles(2);

        //turn on Ball form

        model_01.SetActive(false);
        model_00.SetActive(false);
        model_02.SetActive(true);
        positionMarker.gameObject.SetActive(true);

        model_02.transform.localEulerAngles = Vector3.zero;

        Rigid.useGravity = true;

        canFlash = false;

        isFlying = false;
        startedFlying = false;
        tStartFlight = 0;
        InputHand.Fly = false;

        Rigid.mass = massWhenBall;
        ballActivated = true;

        //ballMesh.SetActive(true);
        //bodyMesh.SetActive(false);
        //faceMesh.SetActive(false);
        //ponchoMesh.SetActive(false);

        States = WorldState.InAir;

        parentOwnCollider.material = ballPhysMat;
        rigidCollider.material = ballPhysMat;
    }
    //stun our character
    public void Stunned(Vector3 PushDirection)
    {
        if (Anim)
            Anim.SetBool("Stunned", true);

        StunTimer = StunnedTime;

        //set physics
        ActSpeed = 0f;
        Rigid.velocity = Vector3.zero;
        Rigid.AddForce(PushDirection * StunPushBack, ForceMode.Impulse);
        DownwardDirection = Vector3.up;
        States = WorldState.Stunned;

        //turn on gravity
        Rigid.useGravity = true;

        isFlying = false;
        startedFlying = false;
        tStartFlight = 0;

        parentOwnCollider.material = bipedPhysMat;
        rigidCollider.material = bipedPhysMat;
    }

    //-----------------------------------------------------------------------------------

    void AnimCtrl()
    {
        //setup the location of any velocity based animations from our hip position 
        Transform RelPos = this.transform;

        //find animations based on our hip position (for flying velocity animations
        if (HipsPos)
            RelPos = HipsPos;
        //get movement amounts in each direction
        Vector3 RelVel = RelPos.transform.InverseTransformDirection(Rigid.velocity);
        Anim.SetFloat("forwardMove", RelVel.z);
        Anim.SetFloat("sideMove", RelVel.x);
        Anim.SetFloat("upwardsMove", RelVel.y);
        //our rigidbody y amount (for upwards or downwards velocity animations
        Anim.SetFloat("YVel", Rigid.velocity.y);

        //set movement animator
        RunTimer = new Vector3(Rigid.velocity.x, 0, Rigid.velocity.z).magnitude;
        Anim.SetFloat("Moving", RunTimer);

        //set our grounded and flying animations
        Anim.SetBool("OnGround", OnGround);
        //bool Fly = true;
        //if (!InputHand.Fly)
        //    Fly = false;

        Anim.SetBool("Flying", isFlying);
    }
    void FixedAnimCtrl(float D) //animations involving a timer
    {
        //setup the xinput animation for tilting our wings left and right
        float LAMT = InputHand.Horizontal;
        XAnimFloat = Mathf.Lerp(XAnimFloat, LAMT, D * 4f);
        Anim.SetFloat("XInput", XAnimFloat);
    }

    //lerp our speed over time
    void LerpSpeed(float d, float TargetSpeed, float Accel)
    {
        //if our speed is larger than our max speed, reduce it slowly 
        if (ActSpeed > MaxSpeed)
        {
            ActSpeed = Mathf.Lerp(ActSpeed, TargetSpeed, d * Accel * 0.5f);
        }
        else
        {
            if (TargetSpeed > 0.5)
            {
                //influence by x and y input 
                float Degree = Vector3.Magnitude(new Vector3(InputHand.Horizontal, InputHand.Vertical, 0).normalized);
                ActSpeed = Mathf.Lerp(ActSpeed, TargetSpeed, (d * Accel) * Degree);
            }
            else
                ActSpeed = Mathf.Lerp(ActSpeed, TargetSpeed, d * Accel);


        }
        //clamp our speed
        ActSpeed = Mathf.Clamp(ActSpeed, 0, SpeedClamp);
    }

    //handle how our speed is increased or decreased when flying
    void HandleVelocity(float d, float TargetSpeed, float Accel, float YAmt)
    {
        if (ActSpeed > FlyingSpeed) //we are over out max speed, slow down slower
        {
            Accel = Accel * 0.8f;
        }

        if (YAmt < FlyingLowerLimit) //we are flying down! boost speed
        {
            TargetSpeed = TargetSpeed + (FlyingVelocityGain * (YAmt * -0.5f));
        }
        else if (YAmt > FlyingUpperLimit) //we are flying up! reduce speed
        {
            TargetSpeed = TargetSpeed - (FlyingVelocityLoss * YAmt);
            ActSpeed -= (FlyingVelocityLoss * YAmt) * d;
        }
        //clamp speed
        TargetSpeed = Mathf.Clamp(TargetSpeed, -SpeedClamp, SpeedClamp);
        //lerp speed
        ActSpeed = Mathf.Lerp(ActSpeed, TargetSpeed, Accel * d);
    }
    //boost our speed
    public void SpeedBoost(float Amt)
    {
        ActSpeed += Amt;
    }

    void MoveSelf(float d, float Speed, float Accel, Vector3 moveDirection)
    {
        if (moveDirection == Vector3.zero)
        {
            targetDir = transform.forward;
        }
        else
        {
            targetDir = moveDirection;
        }

        if (targetDir == Vector3.zero)
        {
            targetDir = transform.forward;
        }
        //turn ctrl
        Quaternion lookDir = Quaternion.LookRotation(targetDir);
        //turn speed after flown is reduced
        if (FlownAdjustmentLerp < 1)
            FlownAdjustmentLerp += delta * 2f;
        //set our turn speed
        float TurnSpd = (turnSpeed + (ActSpeed * 0.1f)) * FlownAdjustmentLerp;
        TurnSpd = Mathf.Clamp(TurnSpd, 0, 6);

        //lerp mesh slower when not on ground
        RotateSelf(DownwardDirection, d, 8f);
        RotateMesh(d, targetDir, TurnSpd);

        //move character
        float Spd = Speed;
        Vector3 curVelocity = Rigid.velocity;
        Vector3 MovDirection = transform.forward;

        if (moveDirection == Vector3.zero) //if we are not pressing a move input we move towards velocity //or are crouching
        {
            Spd = Speed * 0.8f; //less speed is applied to our character
        }

        Vector3 targetVelocity = MovDirection * Spd;
        //accelerate our character
        ActAccel = Mathf.Lerp(ActAccel, Accel, HandleReturnSpeed * d);
        //lerp our movement direction
        Vector3 dir = Vector3.Lerp(curVelocity, targetVelocity, d * ActAccel);
        dir.y = Rigid.velocity.y;

        RaycastHit hit;
        Physics.Raycast(Rigid.position, Vector3.down, out hit, 3);

        float snapMult = ballActivated ? ballSnapMult : bipedSnapMult;
        dir += hit.normal * -(snapMult);
        //set our rigibody direction
        Rigid.velocity = dir;
    }

    void FallingCtrl(float d, float Speed, float Accel, Vector3 moveDirection)
    {
        if (moveDirection == Vector3.zero)
        {
            targetDir = transform.forward;
        }
        else
        {
            targetDir = moveDirection;
        }

        //rotate towards the rigid body velocity 
        Vector3 LerpDirection = DownwardDirection;
        float FallDirSpd = FallingDirectionSpeed;

        if (Rigid.velocity.y < -6) //we are going downwards
        {
            LerpDirection = Vector3.up;
            FallDirSpd = FallDirSpd * -(Rigid.velocity.y * 0.2f);
        }

        DownwardDirection = Vector3.Lerp(DownwardDirection, LerpDirection, FallDirSpd * d);

        //lerp mesh slower when not on ground
        RotateSelf(DownwardDirection, d, 8f);
        RotateMesh(d, transform.forward, turnSpeedInAir);

        //move character
        float Spd = Speed;
        Vector3 curVelocity = Rigid.velocity;

        Vector3 targetVelocity = targetDir * Spd;

        //lerp our acceleration
        ActAccel = Mathf.Lerp(ActAccel, Accel, HandleReturnSpeed * d);
        //set rigid direction
        Vector3 dir = Vector3.Lerp(curVelocity, targetVelocity, d * ActAccel);
        dir.y = Rigid.velocity.y;
        Rigid.velocity = dir;
    }

    void FlyingCtrl(float d, float Speed, float XMove, float ZMove)
    {
        // APLICA LAS ROTACIONES NECESARIAS
        //input direction 
        float InvertX = -1;
        float InvertY = yInvertedOnFlight ? -1 : 1;

        XMove = XMove * InvertX; //horizontal inputs
        ZMove = ZMove * InvertY; //vertical inputs

        //get direction to move character
        DownwardDirection = VehicleFlyingDownwardDirection(d, ZMove);
        Vector3 SideDir = VehicleFlyingSideDirection(d, XMove);
        //get our rotation and adjustment speeds
        float rotSpd = FlyingRotationSpeed;
        float FlyLerpSpd = FlyingAdjustmentSpeed * FlyingAdjustmentLerp;

        //lerp mesh slower when not on ground
        RotateSelf(DownwardDirection, d, rotSpd);
        RotateMesh(d, SideDir, rotSpd);

        if (FlyingTimer < GlideTime * 0.7f) //lerp to velocity if not flying
            RotateToVelocity(d, rotSpd * 0.05f);



        // APLICA LA VELOCIDAD EN EL EJE Z CALCULADA EN HANDLEVELOCITY Y CALCULA Y APLICA LA GRAVEDAD
        Vector3 targetVelocity = transform.forward * Speed;
        //push down more when not pressing fly
        //if (InputHand.Fly)
        ActGravAmt = Mathf.Lerp(ActGravAmt, FlyingGravityAmt, FlyingGravBuildSpeed * 4f * d);
        //else
        //    ActGravAmt = Mathf.Lerp(ActGravAmt, GlideGravityAmt, FlyingGravBuildSpeed * 0.5f * d);

        targetVelocity -= Vector3.up * ActGravAmt;
        //lerp velocity
        Vector3 dir = Vector3.Lerp(Rigid.velocity, targetVelocity, d * FlyLerpSpd);
        Rigid.velocity = dir;
    }

    Vector3 VehicleFlyingDownwardDirection(float d, float ZMove)
    {
        Vector3 VD = -transform.up;

        //up and down input = moving up and down (this effects our downward direction
        if (ZMove > 0.1) //upward tilt
        {
            VD = Vector3.Lerp(VD, -transform.forward, d * (FlyingUpDownSpeed * ZMove));
        }
        else if (ZMove < -.1) //downward tilt
        {
            VD = Vector3.Lerp(VD, transform.forward, d * (FlyingUpDownSpeed * (ZMove * -1)));
        }

        //LB and RB input = roll (this effects our downward direction
        if (InputHand.LB) //left roll
        {
            VD = Vector3.Lerp(VD, -transform.right, d * FlyingRollSpeed);
        }
        else if (InputHand.RB) //right roll
        {
            VD = Vector3.Lerp(VD, transform.right, d * FlyingRollSpeed);
        }

        return VD;
    }

    Vector3 VehicleFlyingSideDirection(float d, float XMove)
    {
        Vector3 RollDir = transform.forward;

        //rb lb = move left and right (this effects our target direction
        //left right input
        if (XMove > 0.1)
        {
            RollDir = Vector3.Lerp(RollDir, -transform.right, d * (FlyingLeftRightSpeed * XMove));
        }
        else if (XMove < -.1)
        {
            RollDir = Vector3.Lerp(RollDir, transform.right, d * (FlyingLeftRightSpeed * (XMove * -1)));
        }
        //bumper input
        if (InputHand.LB)
        {
            RollDir = Vector3.Lerp(RollDir, -transform.right, d * FlyingLeftRightSpeed * 0.2f);
        }
        else if (InputHand.RB)
        {
            RollDir = Vector3.Lerp(RollDir, transform.right, d * FlyingLeftRightSpeed * 0.2f);
        }

        return RollDir;
    }
    //rotate our upwards direction
    void RotateSelf(Vector3 Direction, float d, float GravitySpd)
    {
        Vector3 LerpDir = Vector3.Lerp(transform.up, Direction, d * GravitySpd);
        transform.rotation = Quaternion.FromToRotation(transform.up, LerpDir) * transform.rotation;
    }
    //rotate our left right direction
    void RotateMesh(float d, Vector3 LookDir, float spd)
    {
        Quaternion SlerpRot = Quaternion.LookRotation(LookDir, transform.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, SlerpRot, spd * d);
    }
    //rotate towards the velocity direction
    void RotateToVelocity(float d, float spd)
    {
        Quaternion SlerpRot = Quaternion.LookRotation(Rigid.velocity.normalized);
        transform.rotation = Quaternion.Slerp(transform.rotation, SlerpRot, spd * d);
    }

    public void SetupCharacter()
    {
        //get components
        Anim = GetComponentInChildren<Animator>();
        Rigid = GetComponentInChildren<PlayerCollisionSphere>().GetComponentInChildren<Rigidbody>();

        //detatch rigidbody
        Rigid.transform.parent = null;

        //setup rigidbody link
        PlayerCollisionSphere LinkSet = Rigid.GetComponent<PlayerCollisionSphere>();
        LinkSet.Setup(this);

        //return with our character being in air
        SetInAir();
    }
}
