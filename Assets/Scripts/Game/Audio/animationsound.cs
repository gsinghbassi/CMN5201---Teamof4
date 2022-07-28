using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationsound : MonoBehaviour
{
    bool wait = false;
    int x;
    public AudioClip[] clips;
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
        x = Random.Range(0, clips.Length);
        if (anim.fireEvents == true && !audioData.isPlaying && wait == false)
        {
            audioData.PlayOneShot(clips[x]);
            StartCoroutine(enumerator());
        }
    }
    IEnumerator enumerator()
    {
        wait = true;
        yield return new WaitForSeconds(0.5f);
        wait = false;
    }

}
