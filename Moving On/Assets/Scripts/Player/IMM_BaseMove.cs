using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class IMM_BaseMove : PlayerBase, IMovementModifier
{
    [Header("Movement settings")]
    [SerializeField] private float movementSpeed = 6f;
    [SerializeField] private LayerMask waterMask;
    [SerializeField] private float waterDistance = 0.4f;

    [Header("Rotation settings")]
    [SerializeField] private float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;

    [Header("Animation Settings")]
    [SerializeField] private float timeToStartIdle = 2.5f;
    [SerializeField] private float tIdle = 0;
    [SerializeField] private ParticleSystem stepPuf;

    [Header("Sound Effects")]
    [SerializeField] private AudioSource audioSource;

    private bool idleTriggered = false;
    public bool isWalking;

    public float MovementSpeed { get => movementSpeed; }

    public delegate void WaterCollisionEvent();
    public event WaterCollisionEvent WaterCollision;

    public Vector3 ApplyMovement(Vector3 value)
    {
        if (handler.CanRecieveMovementInput)
        {

            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            animator.SetFloat("Blend", Mathf.Max(Mathf.Abs(horizontal), Mathf.Abs(vertical)));

            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if (direction.magnitude >= 0.1f)
            {
                stepFXInstanciator(true);
                animator.SetBool("LongIdle", false);
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                value = new Vector3(moveDir.normalized.x * movementSpeed, value.y, moveDir.normalized.z * movementSpeed);

                tIdle = 0;
                idleTriggered = false;

                
            }
            else
            {
                value = new Vector3(0, value.y, 0);
                stepFXInstanciator(false);

                if (!idleTriggered)
                {
                    tIdle += Time.deltaTime;
                    if (tIdle >= timeToStartIdle)
                    {
                        idleTriggered = true;
                        StartCoroutine("LongIdleBehaviour");
                    }
                }
                if (handler.IsGrounded) audioSource.Stop();
            }
            
        }

        CheckWaterLevel();
        
        return value;
    }
    public void OnDisable()
    {
        stepPuf.Stop();
        handler.RemoveModifier(this);
    }

    public void OnEnable()
    {
        handler.AddModifier(this);
    }

    private void stepFXInstanciator(bool moving)
    {
        if (moving == true)
        {
            if (isWalking != true)
            {
                stepPuf.Play();
                SoundManager.Instance.GetSoundEffect(SoundEffect.PlayerSteps, audioSource);
                audioSource.loop = true;
                audioSource.Play();
                isWalking = true;
            }
        }
        else
        {
            if (isWalking != false)
            {
                stepPuf.Stop();
                isWalking = false;
            }
        }
    }

    private void CheckWaterLevel()
    {
        if (handler.CanDetectWater && Physics.Raycast(handler.GroundCheck.position, Vector3.down, waterDistance, waterMask))
        {
            WaterCollision?.Invoke();
        }
    }

    private IEnumerator LongIdleBehaviour()
    {
        animator.SetBool("LongIdle", true);
        yield return new WaitForSeconds(1);
        animator.SetBool("LongIdle", false);
    }
}
