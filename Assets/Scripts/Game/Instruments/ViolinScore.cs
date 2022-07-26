using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViolinScore : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private AudioSource ViolinAttackSFX;
    public int Direction;
  

    // Start is called before the first frame update
    void Start()
    {
        switch(Direction)
        {
            case 0:
            rb.velocity = transform.right * speed;
            break;
            case 1:
            rb.velocity = -transform.right * speed;
            break;
            case 2:
            rb.velocity = transform.up * speed;
            break;
            case 3:
            rb.velocity = -transform.up * speed;
            break;
        }
        //rb.velocity = transform.right * speed;
        ViolinAttackSFX.Play();
        Destroy(gameObject, 5f);
        

    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("collision with " + other.gameObject.tag); //debugs whatever has just collided

        if (other.gameObject.tag == "Hunter")
        {
            other.gameObject.GetComponent<EnemyHealthDamage>().TakenDamage(1);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Walls"))
        {
            //Debug.Log("Wall has been hit");
            Destroy(gameObject);
            
        }

    }
}
