using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    float FadeTime;
    Image image; //image

    private void Start()
    {
        image = GetComponent<Image>();
        PlayerController.OnRequestFade += ProccessFade;
    }

    void ProccessFade(bool state, float time)
    {
        FadeTime = time;

        image.enabled = true;

        if (state)
        {
            StartCoroutine("FadeIn");
        }
        else
        {
            StartCoroutine("FadeOut");
        }
    }

    IEnumerator FadeOut()
    {
        float deltaTime = 0;

        while (deltaTime < FadeTime)
        {
            Color color = image.color; //color
            color.a = deltaTime / FadeTime;
            image.color = color;
            yield return null;
            deltaTime += Time.deltaTime;
        }
    }

    IEnumerator FadeIn()
    {
        float deltaTime = 0;

        while (deltaTime < FadeTime)
        {
            Color color = image.color; //color
            color.a = 1 - (deltaTime / FadeTime);
            image.color = color;
            yield return null;
            deltaTime += Time.deltaTime;
        }
    }
}
