using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum LODSZones { CaveInit, CaveTree, CaveOutTunnel, OutsideWorld }
public class LODSManager : Singleton<LODSManager>
{
    [SerializeField] private GameObject caveInit, caveTree, caveOutTunnel, outsideWorld;

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
