using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarScore : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Hunter"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }


    }

}
