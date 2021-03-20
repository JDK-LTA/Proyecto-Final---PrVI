using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : PlayerBase
{
    [Header("General Settings")]
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private List<Transform> groundCheckers = new List<Transform>();
    [SerializeField] private List<Transform> planeCheckers = new List<Transform>();

    private readonly List<IMovementModifier> modifiers = new List<IMovementModifier>();
    private readonly List<ISpecialModifier> specialModifiers = new List<ISpecialModifier>();
    
    [Header("Debug")]
    [SerializeField] private Vector3 movement = Vector3.zero;
    [SerializeField] private bool isGrounded;
    [SerializeField] private bool isWatered;

    private bool canDetectWater;

    private bool canMove = true;
    private bool canRecieveMovementInput = true;

    public float Gravity { get => gravity; }
    public bool IsGrounded { get => isGrounded; set => isGrounded = value; }
    public Transform GroundCheck { get => groundCheck; }
    public List<Transform> GroundCheckers { get => groundCheckers; }
    public List<Transform> PlaneCheckers { get => planeCheckers; }
    public bool CanMove { get => canMove; set => canMove = value; }
    public bool CanDetectWater { get => canDetectWater; set => canDetectWater = value; }
    public bool IsWatered { get => isWatered; set => isWatered = value; }
    public bool CanRecieveMovementInput { get => canRecieveMovementInput; set => canRecieveMovementInput = value; }

    public void AddModifier(IMovementModifier modifier)
    {
        modifiers.Add(modifier);
    }
    public void AddModifier(ISpecialModifier modifier)
    {
        specialModifiers.Add(modifier);
    }
    public void RemoveModifier(IMovementModifier modifier)
    {
        modifiers.Remove(modifier);
    }
    public void RemoveModifier(ISpecialModifier modifier)
    {
        specialModifiers.Remove(modifier);
    }

    private void Update()
    {
        if (canMove)
            Move();

        canDetectWater = movement.y < 0;
    }
    private void FixedUpdate()
    {
        if (canMove)
            SpecialMove();
    }

    

    private void Move()
    {
        for (int i = 0; i < modifiers.Count; i++)
        {
            IMovementModifier mod = modifiers[i];
            movement = mod.ApplyMovement(movement);
        }
        controller.Move(movement * Time.deltaTime);
    }
    private void SpecialMove()
    {
        for (int i = 0; i < specialModifiers.Count; i++)
        {
            specialModifiers[i].ApplyMovement(rb);
        }
    }
    public void SyncTransform()
    {
        Physics.SyncTransforms();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //GameManager.Instance.Player = this;
        StopMovement();
    }

    public void StopMovement()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        movement = Vector3.zero;
        canMove = false;
    }
    public void RestartMovement()
    {
        canMove = true;
    }
    public void StopInput()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        movement = Vector3.zero;
        canRecieveMovementInput = false;
    }
}
