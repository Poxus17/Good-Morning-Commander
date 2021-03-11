using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightManager : MonoBehaviour
{
    Light light; //Light.
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        PlayerController.OnDim += AdjustLightIntensity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AdjustLightIntensity(float change)
    {
        light.intensity += change;
    }
}
