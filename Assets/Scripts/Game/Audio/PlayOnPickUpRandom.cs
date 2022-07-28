using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnPickUpRandom : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;


    AudioClip RandomClip()
    {
        return audioClipArray[Random.Range(0, audioClipArray.Length)];
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            audioSource.PlayOneShot(RandomClip());
        }
    }

}