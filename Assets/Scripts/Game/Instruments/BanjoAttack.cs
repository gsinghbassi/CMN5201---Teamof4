using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BanjoAttack : MonoBehaviour
{
    private int banjo = 0;
    private bool inventoryBanjo = false;
    [SerializeField] private Text banjotext;
    [SerializeField] Transform attackingPoint;
    [SerializeField] GameObject musicScorePrefab;
    

    // Update is called once per frame
    void Update()
    {
        if (inventoryBanjo == true)
        {

            if (Input.GetButtonDown("Fire1")) //Press the left CTRL
            {
                Shoot();
            }
        }
        if (counter == 2)
        {
            inventoryBanjo = false;
            banjoIcon.SetActive(false);
            isInInventory = false;
        }

    }
    void Shoot()
    {
        Instantiate(musicScorePrefab, attackingPoint.position, attackingPoint.rotation);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isInInventory == false)
        {

            if (collision.gameObject.tag == "Banjo")
            {
                Destroy(collision.gameObject);
                banjo++;
                banjotext.text = "Banjo: " + banjo;
                inventoryBanjo = true;
                banjoIcon.SetActive(true);
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
