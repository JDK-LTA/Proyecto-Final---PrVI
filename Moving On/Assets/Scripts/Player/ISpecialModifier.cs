using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpecialModifier
{
    void OnEnable();
    void OnDisable();
    void ApplyMovement(Rigidbody rb);
}
