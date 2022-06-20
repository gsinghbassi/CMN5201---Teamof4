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
    [SerializeField] GameObject guitarIcon;
    private int counter = 0;
    private bool isInInventory = false;

    private void Start()
    {
        guitarIcon.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (inventoryGuitar == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
                guitarIcon.SetActive(false);
                inventoryGuitar = false;
            }
        }
        if (counter == 1)
        {
            inventoryGuitar = false;
            guitarIcon.SetActive(false);
            isInInventory = false;
        }

    }
    public void Shoot()
    {
        Rigidbody2D clone;
        clone = Instantiate(Score, transform.position, transform.rotation);
        Destroy(clone.gameObject,ScoreLifeSpan);
        counter++;
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isInInventory == false)
        {

            if (collision.gameObject.tag == "Guitar")
            {
                Destroy(collision.gameObject);
                guitar++;
                guitartext.text = "Guitar: " + guitar;
                inventoryGuitar = true;
                guitarIcon.SetActive(true);
                counter = 0;
                isInInventory = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Hunter")
        {
            collision.gameObject.GetComponent<EnemyHealthDamage>().TakenDamage(1);
        }
    }

}
