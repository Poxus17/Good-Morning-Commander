using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayPasser : MonoBehaviour
{
    public DayManager dayManager;
    private void OnMouseDown()
    {
        dayManager.DayUp();
    }
}