using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera mainCam;
    public Camera psyCam;

    // Start is called before the first frame update
    void Start()
    {
        psyCam.enabled = false;
        mainCam.enabled = true;
    }

    void SwitchCamera()
    {
        psyCam.enabled = !psyCam.enabled;
        mainCam.enabled = !mainCam.enabled;
    }
}
