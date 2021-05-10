using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDeactivate : MonoBehaviour
{
    [SerializeField] private bool deactivateParent = false;
    [SerializeField] private float timeToDeactivate = 2f;
    float t = 0;
    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= timeToDeactivate)
        {
            t = 0;
            if (!deactivateParent)
                gameObject.SetActive(false);
            else
                transform.parent.gameObject.SetActive(false);
        }
    }
}
