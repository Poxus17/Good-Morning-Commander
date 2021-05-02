using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepManager : MonoBehaviour
{
    public float footstepDelay; //Time to put between footsteps

    float deltaFromLast; //The time passed since the last footstep

    bool AllowStep;

    AudioSource[] sources;

    public AudioClip[] clips;

    // Start is called before the first frame update
    void Start()
    {
        sources = GetComponents<AudioSource>();

        PlayerController.OnMove += Step;
    }

    // Update is called once per frame
    void Update()
    {
        deltaFromLast += Time.deltaTime;
        AllowStep = (deltaFromLast >= footstepDelay);

        if (Input.GetKeyDown(KeyCode.P))
        {
            Step();
        }
    }



    void Step()
    {
        if (AllowStep)
        {
            int seed = Random.Range(0, sources.Length - 1); //like no not really, it the resuslt of randomness not the source of it, but I wanted to call the index randomly selected "seed" sue me
            AudioSource source = sources[seed];

            int clipSeed = Random.Range(0, clips.Length - 1); //Bite me
            AudioClip clip = clips[clipSeed];

            source.clip = clip;
            source.Play();

            deltaFromLast = 0;
        }
    }


}
