using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarScore : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    [SerializeField] private AudioSource guitarAttackSFX;
    // Start is called before the first frame update
    void Start()
    {
        guitarAttackSFX.Play();
    }




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Hunter"))
        {
            //Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Walls"))
        {
            Destroy(gameObject);
        }

    }
}

