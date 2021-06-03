using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum LODSZones { CaveInit, CaveTree, CaveOutTunnel, OutsideWorld }
public class LODSManager : Singleton<LODSManager>
{
    [SerializeField] private GameObject caveInit, caveTree, caveOutTunnel, outsideWorld;
    [SerializeField] private bool DEBUG = false;

    private float lateStartTimer = 0.5f;
    private float t = 0;
    private bool lateStart = true;
    private void Update()
    {
        if (DEBUG)
        {
            if (lateStart)
            {
                t += Time.deltaTime;
                if (t >= lateStartTimer)
                {
                    t = 0;
                    lateStart = false;
                    SetLODActive(LODSZones.CaveOutTunnel, false);
                    SetLODActive(LODSZones.CaveTree, false);
                    SetLODActive(LODSZones.OutsideWorld, false);
                }
            }
        }
    }
    public void SetLODActive(LODSZones zone, bool active)
    {
        switch (zone)
        {
            case LODSZones.CaveInit:
                caveInit.SetActive(active);
                break;
            case LODSZones.CaveTree:
                caveTree.SetActive(active);
                break;
            case LODSZones.CaveOutTunnel:
                caveOutTunnel.SetActive(active);
                break;
            case LODSZones.OutsideWorld:
                outsideWorld.SetActive(active);
                break;
        }
    }
}
