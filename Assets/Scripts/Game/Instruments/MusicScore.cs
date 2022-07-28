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
        Destroy(gameObject, 5f);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

       if (other.gameObject.tag=="Hunter")
        {
            other.gameObject.GetComponent<EnemyHealthDamage>().TakenDamage(10);
            Destroy(gameObject);
      }
        if (other.gameObject.CompareTag("Walls"))
        {
            Destroy(gameObject);
        }

    }


}

