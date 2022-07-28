using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationsound : MonoBehaviour
{
    Animator anim;
    AnimationEvent evt;
    public AudioSource audioData;
    public void Start()
    {
        anim = GetComponent<Animator>();
        evt = GetComponent<AnimationEvent>();
        audioData = GetComponent<AudioSource>();
    }
    public void Update()
    {
        if(anim.fireEvents == true && !audioData.isPlaying)
        {
            audioData.Play();
        }
    }
}
