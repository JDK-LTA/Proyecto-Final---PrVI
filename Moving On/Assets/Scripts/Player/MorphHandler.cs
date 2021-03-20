using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerForm { HUMANOID, PLANE, BOAT }

public class MorphHandler : MonoBehaviour
{
    [SerializeField] private PlayerForm playerForm = PlayerForm.HUMANOID;
    [SerializeField] private GameObject anthroParent, planeParent, boatParent;
    [SerializeField] private ParticleSystem smokeParticles;

    [Header("Sound Effects")]
    [SerializeField] private AudioSource transformationSound;
    [SerializeField] private AudioSource collidingSound;
    [SerializeField] private AudioSource waterSplashSound;

    private MovementHandler handler;

    //MESH SWAPPER
    //private MeshSwapper meshSwapper;

    private IMM_BaseMove humanMove;
    private IMM_BaseJump humanJump;
    private IMM_PlaneMove planeMove;
    //private ISM_BoatFloater boatFloater;
    //private ISM_BoatController boatController;

    private CharacterController chController;

    private Rigidbody rb;

    private List<PlayerBase> mods = new List<PlayerBase>();

    private float fStep, fRadius, fHeight;
    private bool isFirstTime = true;

    private bool canMessagePlane = false;

    private bool canBoat = false, canPlane = false;
    [SerializeField] private bool activateAllFormsSinceStart = false;

    public PlayerForm PlayerForm { get => playerForm; }

    private void Awake()
    {
        //MESH SWAPPER
        //meshSwapper = GetComponent<MeshSwapper>();

        handler = GetComponent<MovementHandler>();
        chController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();

        fStep = chController.stepOffset;
        fRadius = chController.radius;
        fHeight = chController.height;

        humanMove = GetComponent<IMM_BaseMove>();
        mods.Add(humanMove);
        humanJump = GetComponent<IMM_BaseJump>();
        mods.Add(humanJump);
        planeMove = GetComponent<IMM_PlaneMove>();
        mods.Add(planeMove);
        //boatFloater = GetComponent<ISM_BoatFloater>();
        //mods.Add(boatFloater);
        //boatController = GetComponent<ISM_BoatController>();
        //mods.Add(boatController);

        planeMove.OriginalVel = humanMove.MovementSpeed;

        canBoat = canPlane = activateAllFormsSinceStart;    //IF COMMENTED PLAYER CAN DIE WITH WATER NOW
    }

    private void Start()
    {
        UpdateComponents(playerForm);

        humanMove.WaterCollision += TouchWaterReciever;
        planeMove.FallenGround += TouchGroundReciever;
        planeMove.FallenWater += TouchWaterReciever;
        //boatController.ReturnToBase += TouchGroundReciever;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && playerForm != PlayerForm.HUMANOID)
        {
            SoundManager.Instance.GetSoundEffect(SoundEffect.PlayerFolding, transformationSound);
            transformationSound.Play();
            UpdateComponents(PlayerForm.HUMANOID);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && playerForm != PlayerForm.PLANE && !handler.IsGrounded && canPlane)
        {
            SoundManager.Instance.GetSoundEffect(SoundEffect.PlayerFolding, transformationSound);
            transformationSound.Play();
            UpdateComponents(PlayerForm.PLANE);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && playerForm != PlayerForm.BOAT && canBoat)
        {
            SoundManager.Instance.GetSoundEffect(SoundEffect.PlayerFolding, transformationSound);
            transformationSound.Play();
            UpdateComponents(PlayerForm.BOAT);
        }
    }

    private void TouchGroundReciever()
    {
        SoundManager.Instance.GetSoundEffect(SoundEffect.PlayerColliding, collidingSound);
        collidingSound.Play();
        UpdateComponents(PlayerForm.HUMANOID);
    }

    private void TouchWaterReciever()
    {
        if (canBoat)
        {
            SoundManager.Instance.GetSoundEffect(SoundEffect.PlayerWaterSplash, waterSplashSound);
            waterSplashSound.Play();
            handler.IsWatered = true;
            UpdateComponents(PlayerForm.BOAT);
        }
        else
        {
            //SaveAndLoadManager.Instance.LoadPlayerData();
        }
    }

    public void UpdateComponents(PlayerForm form)
    {
        DeactivateAllMods();
        ActivateFormMods(form);
    }

    public void ActivateFormMods(PlayerForm form)
    {
        if (isFirstTime)
            isFirstTime = false;
        else
            smokeParticles.Play();

        switch (form)
        {
            case PlayerForm.HUMANOID:
                SetFormToHumanoid();
                break;
            case PlayerForm.PLANE:
                SetFormToPlane();
                break;
            case PlayerForm.BOAT:
                SetFormToBoat();
                break;
            default:
                SetFormToHumanoid();
                break;
        }

        playerForm = form;
    }

    private void SetFormToBoat()
    {
        //boatController.enabled = true;
        //boatFloater.enabled = true;

        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);

        chController.enabled = false;

        rb.isKinematic = false;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

        boatParent.SetActive(true);
    }

    private void SetFormToPlane()
    {
        planeMove.enabled = true;

        chController.stepOffset = 0;
        chController.radius = 0;
        chController.height = 0;

        planeParent.SetActive(true);
    }

    private void SetFormToHumanoid()
    {
        humanMove.enabled = true;
        humanJump.enabled = true;

        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);

        anthroParent.SetActive(true);
    }

    public void ActivateForm(PlayerForm form)
    {
        switch (form)
        {
            case PlayerForm.HUMANOID:
                break;
            case PlayerForm.PLANE:
                canPlane = true;
                //StartCoroutine(UIManager.Instance.TurnToPlaneMessageBehaviour());
                break;
            case PlayerForm.BOAT:
                canBoat = true;
                //StartCoroutine(UIManager.Instance.TurnToBoatMessageBehaviour());
                break;
            default:
                break;
        }
    }

    public void DeactivateSpecificMods(List<MonoBehaviour> components)
    {
        foreach (MonoBehaviour mono in components)
        {
            mono.enabled = false;
        }
    }
    private void DeactivateAllMods()
    {
        foreach (PlayerBase mod in mods)
        {
            mod.enabled = false;
        }

        chController.enabled = true;

        ResetCharacterController();
        ResetRigidbody();

        DeactivateFormModels();
    }

    private void DeactivateFormModels()
    {
        anthroParent.SetActive(false);
        boatParent.SetActive(false);
        planeParent.SetActive(false);
    }

    private void ResetRigidbody()
    {
        rb.isKinematic = true;
        rb.constraints = RigidbodyConstraints.None;
    }

    private void ResetCharacterController()
    {
        chController.radius = fRadius;
        chController.height = fHeight;
        chController.stepOffset = fStep;
    }
}
