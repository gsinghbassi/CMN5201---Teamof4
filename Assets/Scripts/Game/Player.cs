using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public int maxhealth = 100;
    public int currenthealth;
    public int health;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        Slider slider = GetComponent<Slider>(); 
        currenthealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TakenDamage(1);
        }
        TakenDamage(1);
    }
    
    public void TakenDamage(int Damage)
    {
        currenthealth -= Damage;

        healthBar.SetHealth(currenthealth);
    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            health -= currenthealth;
        }
    }*/
}
