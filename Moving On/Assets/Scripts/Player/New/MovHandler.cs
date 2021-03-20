using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovHandler : PlayerParent
{
    [SerializeField] private List<Transformation> transformationsList = new List<Transformation>();

    public void ChangeIntoTransformation(Transformation transformation)
    {
        foreach (Transformation trans in transformationsList)
        {
            trans.enabled = false;
        }

        transformation.enabled = true;
    }
}
