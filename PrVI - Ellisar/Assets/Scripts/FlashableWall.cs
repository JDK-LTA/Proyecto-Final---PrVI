using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashableWall : MonoBehaviour
{
    [SerializeField] private float timeToReset = 5f;
    private float t = 0;
    private bool flashed = false;

    private GameObject meshChild, particlesChild;

    private void Start()
    {
        meshChild = GetComponentInChildren<MeshRenderer>().gameObject;
        //particlesChild = GetComponentInChildren<ParticleSystem>().gameObject;
    }

    public void GetFlashed()
    {
        if (!flashed)
        {
            flashed = true;
            //flash
            meshChild.SetActive(false);
            //particlesChild.SetActive(true);
        }
    }
    private void Unflash()
    {
        //unflash
        meshChild.SetActive(true);
        //particlesChild.SetActive(false);
    }

    private void Update()
    {
        if (flashed)
        {
            t += Time.deltaTime;
            if (t >= timeToReset)
            {
                t = 0;
                flashed = false;
                Unflash();
            }
        }
    }
}
