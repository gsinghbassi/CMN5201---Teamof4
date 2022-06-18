using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuitarAttack : MonoBehaviour
{
    private int guitar = 0;
    private bool inventoryGuitar = false;
    [SerializeField] private Text guitartext;


    [SerializeField] Transform firePoint;
  [SerializeField] float ScoreLifeSpan;
    [SerializeField] Rigidbody2D Score;
  

    // Update is called once per frame
    void Update()
    {
        if (inventoryGuitar == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }
        
    }
    void Shoot()
    {
        Rigidbody2D clone;
        clone = Instantiate(Score, transform.position, transform.rotation);
        Destroy(clone.gameObject,ScoreLifeSpan);
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Guitar")
        {
            Destroy(collision.gameObject);
           guitar++;
            guitartext.text = "Guitar: " + guitar;
           inventoryGuitar = true;
        }
    }
}
