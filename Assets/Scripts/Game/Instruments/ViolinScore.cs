using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViolinScore : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;

    [SerializeField] private AudioSource ViolinAttackSFX;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        ViolinAttackSFX.Play();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collision with " + other.gameObject.tag); //debugs whatever has just collided

        if (other.gameObject.CompareTag("Hunter"))
        {
            //Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Walls"))
        {
            Debug.Log("Wall has been hit");
            Destroy(gameObject);
            
        }

    }
}
