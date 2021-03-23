using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovementModifier
{
    void OnEnable();
    void OnDisable();
    Vector3 ApplyMovement(Vector3 value);
}
