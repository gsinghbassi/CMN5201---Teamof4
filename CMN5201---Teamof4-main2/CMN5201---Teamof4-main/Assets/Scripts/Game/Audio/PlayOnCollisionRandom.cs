using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCollisionRandom: MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;
    

    AudioClip RandomClip()
    {
        return audioClipArray[Random.Range(0, audioClipArray.Length)];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            audioSource.PlayOneShot(RandomClip());
        }
    }

}
