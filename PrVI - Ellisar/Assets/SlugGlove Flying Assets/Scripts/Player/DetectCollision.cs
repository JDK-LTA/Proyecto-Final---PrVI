using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   // public Transform MovementMesh; //what we are checking the ground based on

    public float bottomYOffset, bottomZOffset;
    public float frontOffset;
    public float collisionGroundRadius = 0.8f, collisionWallRadius = 0.3f, collisionBallWallRadius = 1.3f;
    public LayerMask GroundLayer, ballDestroyableLayer;
    public float WallDistance;

    //check if there is a floor to stand on, or land on
    public bool CheckGround()
    {
        Vector3 Pos = transform.position + (-transform.up * bottomYOffset) + (transform.forward * bottomZOffset);
        Collider[] hitColliders = Physics.OverlapSphere(Pos, collisionGroundRadius, GroundLayer);
        if (hitColliders.Length > 0)
        {
            //we are on the ground
            return true;
        }

        return false;
    }

    //check if there is a wall to crash into
    public bool CheckWall()
    {
        Vector3 Pos2 = transform.position + (transform.forward * frontOffset);
        Collider[] hitColliders = Physics.OverlapSphere(Pos2, collisionWallRadius, GroundLayer);

        if (hitColliders.Length > 0)
        {
            return true;
        }

        return false;
    }

    public Collider CheckBallWall()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, collisionBallWallRadius, ballDestroyableLayer);

        if (hitColliders.Length > 0)
        {
            return hitColliders[0];
        }

        return null;
    }

    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Vector3 Pos = transform.position + (-transform.up * bottomYOffset) + (transform.forward * bottomZOffset);
        Gizmos.DrawSphere(Pos, collisionGroundRadius);
        Gizmos.color = Color.red;
        Vector3 Pos2 = transform.position + (transform.forward * frontOffset);
        Gizmos.DrawSphere(Pos2, collisionWallRadius);
    }
}
