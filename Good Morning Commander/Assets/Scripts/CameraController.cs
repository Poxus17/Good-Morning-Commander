using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float transitionTime;
    bool inTransition;

    // Start is called before the first frame update
    void Start()
    {
        CameraTrigger.OnTriggered += MoveTo;
        inTransition = false;
    }

    void MoveTo(Vector3 pos)
    {
        if (!inTransition && pos != transform.localPosition)
        {
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
