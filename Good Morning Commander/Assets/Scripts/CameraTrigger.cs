using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Vector3 TriggerPosition;
    public delegate void Triggered(Vector3 pos);
    public static event Triggered OnTriggered;

    bool inCollision = false;


    private void OnTriggerEnter(Collider other)
    {
        if (OnTriggered != null & !inCollision)
        {
            inCollision = true;
            OnTriggered(TriggerPosition);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Out");
        inCollision = false;
    }
}
