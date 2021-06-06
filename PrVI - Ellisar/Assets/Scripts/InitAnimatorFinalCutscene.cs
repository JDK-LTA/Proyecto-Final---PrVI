using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitAnimatorFinalCutscene : MonoBehaviour
{
    [SerializeField] private float timeToStart = 1f;
    private float t = 0;
    private bool stop = false;
    private Animator anim;
    [SerializeField] private ParticleSystem particlesL, particlesR;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (!stop)
        {
            t += Time.deltaTime;
            if (t >= timeToStart)
            {
                t = 0;
                stop = true;
                anim.SetTrigger("Start");
            }
        }
    }

    public void StartParticles()
    {
        particlesL.Play();
        particlesR.Play();
    }
}
