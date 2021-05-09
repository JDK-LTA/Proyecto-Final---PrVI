using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFX_Manager : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] particleList_ToHumanoid;
    [SerializeField] private ParticleSystem[] particleList_ToFly;
    [SerializeField] private ParticleSystem[] particleList_ToBall;

    public void PlayParticles(int i)
    {
        if (i == 0)
        {
            for(int j=0; j < particleList_ToHumanoid.Length; j++)
            {
                particleList_ToHumanoid[j].Play();
            }
        }
        if (i == 1)
        {
            for (int j = 0; j < particleList_ToFly.Length; j++)
            {
                particleList_ToFly[j].Play();
            }
        }
        if (i == 2)
        {
            for (int j = 0; j < particleList_ToBall.Length; j++)
            {
                particleList_ToBall[j].Play();
            }
        }
    }
}
