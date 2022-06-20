using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViolinAttack : MonoBehaviour
{
    private int violin = 0;
    private bool inventoryViolin = false;
    [SerializeField] private Text violintext;
    [SerializeField] Transform attackingPoint;
    [SerializeField] GameObject musicScorePrefab;

    // Update is called once per frame
    void Update()
    {
        if (inventoryViolin == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Shoot();
            }
        }
    }
    void Shoot()
    {
        Instantiate(musicScorePrefab, attackingPoint.position, attackingPoint.rotation);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Violin")
        {
            Destroy(collision.gameObject);
            violin++;
            violintext.text = "Violin: " + violin;
            inventoryViolin = true;
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

