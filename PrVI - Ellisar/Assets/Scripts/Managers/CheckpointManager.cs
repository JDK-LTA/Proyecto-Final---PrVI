using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : Singleton<CheckpointManager>
{
    public static Transform actualCheckpoint;
    private PlayerMovement player;
    private Cinemachine.CinemachineFreeLook cmBrain;

    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        cmBrain = FindObjectOfType<Cinemachine.CinemachineFreeLook>();

        GameObject copy = Instantiate(new GameObject(), player.transform.position, player.transform.rotation);
        actualCheckpoint = copy.transform;
    }

    private void RespawnPlayer()
    {
        player.Rigid.position = actualCheckpoint.position;
        player.Rigid.rotation = actualCheckpoint.rotation;
        player.transform.rotation = actualCheckpoint.rotation;
        player.Rigid.velocity = Vector3.zero;
        player.SetBiped();
        cmBrain.Follow = player.transform;
        Physics.SyncTransforms();
    }
    public void DelayedRespawn(float delay)
    {
        Invoke("RespawnPlayer", delay);
    }
}
