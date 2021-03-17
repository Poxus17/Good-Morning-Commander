using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePointer : MonoBehaviour
{
    public float floatModifier; //The factor of the distance of the movement cycle
    public float floatSpeed; //The factor of the speed of the movement cycle
    public float baseY; //The initial Y height from which the movement cycles starts;
    public Vector3 defaultRotation;

    GameObject self;

    private void Awake()
    {
        transform.eulerAngles = defaultRotation;
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerController.OnMoveStatusChanged += KillSelf;
        self = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = transform.position;
        newpos.y = baseY + Mathf.Sin(Time.time * floatSpeed) * floatModifier;
        transform.position = newpos;
    }

    void KillSelf(bool confirm)
    {
        if (!confirm)
        {
            Destroy(self);
        }
    }
}
