using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashableWall : MonoBehaviour
{
    [SerializeField] private float timeToReset = 5f;
    private float t = 0;
    private bool flashed = false;

    private MeshRenderer [] meshChild;
    private GameObject particlesChild;

    private void Start()
    {
        meshChild = GetComponentsInChildren<MeshRenderer>();
        //particlesChild = GetComponentInChildren<ParticleSystem>().gameObject;
    }

    public void GetFlashed()
    {
        if (!flashed)
        {
            flashed = true;
            //flash
            foreach (MeshRenderer mesh in meshChild)
            {
                mesh.enabled = false;
                mesh.GetComponent<MeshCollider>().enabled = false;

            }
            //particlesChild.SetActive(true);
        }
    }
    private void Unflash()
    {
        //unflash
        foreach (MeshRenderer mesh in meshChild)
        {
            mesh.enabled = true;
            mesh.GetComponent<MeshCollider>().enabled = true;
        }
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
