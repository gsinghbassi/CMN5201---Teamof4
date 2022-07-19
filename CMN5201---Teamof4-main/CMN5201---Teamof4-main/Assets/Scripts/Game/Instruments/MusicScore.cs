using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScore : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;

    [SerializeField] private AudioSource banjoAttackSFX;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity= transform.right *speed;
        banjoAttackSFX.Play();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

       // if (other.gameObject.CompareTag("Hunter"))
        //{
            //Destroy(other.gameObject);
            //Destroy(gameObject);
       //}
        if (other.gameObject.CompareTag("Walls"))
        {
            Destroy(gameObject);
        }

    }


}

