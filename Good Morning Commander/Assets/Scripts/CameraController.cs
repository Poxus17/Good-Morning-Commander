using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Camera myCam;

    public bool initialState; //Is initially on?

    private void Start()
    {
        myCam = GetComponent<Camera>();

        BasicInkExample.OnChangePsyState += SetEnabledByInitial;
    }

    void SetEnabledByInitial(bool setTo) //This function always sets true initial to input, and false initial to the reverse of the input
    {
        myCam.enabled = (initialState) ? !setTo : setTo;
    }

    private void OnDestroy()
    {
        BasicInkExample.OnChangePsyState -= SetEnabledByInitial;
    }
}
