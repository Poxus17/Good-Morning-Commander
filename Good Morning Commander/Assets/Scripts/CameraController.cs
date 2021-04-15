using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float transitionTime;
    bool inTransition;
    Vector3 camPosPoint;

    // Start is called before the first frame update
    void Start()
    {
        CameraTrigger.OnTriggered += MoveTo;
        inTransition = false;
        camPosPoint = new Vector3(19, 8, -19);
        transform.localPosition = new Vector3(19, 8, -19);
    }

    void MoveTo(Vector3 pos)
    {
        if (!inTransition && pos != camPosPoint)
        {
            Debug.Log(pos);
            camPosPoint = pos;
            IEnumerator coroutine = transitionToTrigger(pos);
            StartCoroutine(coroutine);
        }
        
    }

    IEnumerator transitionToTrigger(Vector3 pos)
    {
        inTransition = true;
        Vector3 startPos = transform.localPosition;
        float timeElapsed = 0;

        while(timeElapsed <= transitionTime)
        {
            transform.localPosition = Vector3.Lerp(startPos, pos, (timeElapsed / transitionTime));
            yield return 0;
            timeElapsed += Time.deltaTime;

        }

        inTransition = false;
    }
}
