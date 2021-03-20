using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMM_BaseJump : PlayerBase, IMovementModifier
{
    [Header("Jump stats")]
    [SerializeField] private float jumpHeight = 3;
    [SerializeField] private int nOfJumps = 2;

    [Header("Ground checker variables")]
    [SerializeField] private float groundDistance = 1.1f;
    [SerializeField] private float groundDistanceForLandingAnimation = 0.5f;
    [SerializeField] private LayerMask groundMask;

    [Header("Animations")]
    [SerializeField] private ParticleSystem stepPuf;

    [Header("Sound Effects")]
    [SerializeField] private AudioSource audioSource;

    [Header("Debug")]
    [SerializeField] private Vector3 velocity;
    private int auxJumps = 0;
    private bool canDoubleJump = true;
    [SerializeField] private bool justLanded = true;
    private bool normalJump = false;
    //private bool freeFall = false;
    private bool isLanding = false;

    public bool CanDoubleJump { set => canDoubleJump = value; }

    public Vector3 ApplyMovement(Vector3 value)
    {
        CheckGrounded();
        CheckLanding();

        if (handler.IsGrounded) auxJumps = 0;
        else if (!handler.IsGrounded && auxJumps == 0) auxJumps++;

        if (handler.CanRecieveMovementInput && Input.GetButtonDown("Jump") && auxJumps < nOfJumps)
        {
            Jump();
        }

        GravityEffect();
        value.y = velocity.y;

        return value;
    }

    public void Jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * handler.Gravity);
        handler.CanDetectWater = false;
        stepPuf.Stop(); ;
        audioSource.Stop();
        SoundManager.Instance.GetSoundEffect(SoundEffect.PlayerJump, audioSource);
        audioSource.loop = false;
        audioSource.Play();

        if (auxJumps > 0)
        {
            audioSource.Play();
            StartCoroutine("DoubleJumpBehaviour");
        }

        auxJumps++;

        justLanded = false;
        StartCoroutine("TakeOffBehaviour");
        normalJump = true;
    }
    private void GravityEffect()
    {
        velocity.y += handler.Gravity * Time.deltaTime;
    }

    public void OnDisable()
    {
        handler.RemoveModifier(this);
        auxJumps = 0;
    }

    public void OnEnable()
    {
        handler.AddModifier(this);
        CheckGrounded();

        justLanded = handler.IsGrounded;
        if (!handler.IsGrounded && !handler.IsWatered)
        {
            auxJumps = 2;
        }
        else if(handler.IsGrounded)
        {
            auxJumps = 0;
        }
        else
        {
            handler.IsWatered = false;
            auxJumps = 1;
        }
    }

    private void CheckGrounded()
    {
        handler.IsGrounded = RayCasting(handler.GroundCheckers, groundDistance, groundMask);

        if (handler.IsGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
            animator.SetBool("Falling", false);
        }

        //if (!handler.IsGrounded && !normalJump && !freeFall && !isLanding)
        if (!handler.IsGrounded)
        {
            //freeFall = true;
            animator.SetBool("Falling", true);
            
        }
    }

    private void CheckLanding()
    {
        if (isLanding)
        {
            isLanding = !handler.IsGrounded;
        }
        if (!handler.IsGrounded && !justLanded)
        {
            //if (RayCasting(handler.GroundCheckers, groundDistanceForLandingAnimation, groundMask))  StartCoroutine("LandingBehaviour"); 
            justLanded = velocity.y < 0 ? RayCasting(handler.GroundCheckers, groundDistanceForLandingAnimation, groundMask) : false;
            if (justLanded)
            {
                if (GetComponent<IMM_BaseMove>().isWalking)
                {
                    SoundManager.Instance.GetSoundEffect(SoundEffect.PlayerSteps, audioSource);
                    audioSource.loop = true;
                    audioSource.Play();
                    stepPuf.Play();
                    //StepPufJumpBehaviour();
                }
                //StartCoroutine("LandingBehaviour");
                normalJump = false;
                //freeFall = false;
                isLanding = true;
            }
        }
    }

    private IEnumerator TakeOffBehaviour()
    {
        yield return new WaitForSeconds(0.01f);
        animator.SetBool("TakeOff", true);
        yield return new WaitForSeconds(0.01f);
        animator.SetBool("TakeOff", false);
    }
    private IEnumerator DoubleJumpBehaviour()
    {
        yield return new WaitForSeconds(0.01f);
        animator.SetBool("DoubleJump", true);
        yield return new WaitForSeconds(0.01f);
        animator.SetBool("DoubleJump", false);
    }

    //private IEnumerator StepPufJumpBehaviour()
    //{
    //    yield return new WaitForSeconds(0.01f);
    //    stepPuf.Play();
    //}
    //private IEnumerator LandingBehaviour()
    //{
    //    yield return new WaitForSeconds(0.01f);
    //    animator.SetBool("Landing", true);
    //    yield return new WaitForSeconds(0.01f);
    //    animator.SetBool("Landing", false);
    //}
}
