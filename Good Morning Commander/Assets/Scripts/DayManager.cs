using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayManager : MonoBehaviour
{
    public int day = 0;
    public int MinDay = 0;
    public int MaxDay = 0;

    public void DayUp()
    {
        day += 1*(Random.Range(MinDay,MaxDay));
        print("Day " + day);
    }

}