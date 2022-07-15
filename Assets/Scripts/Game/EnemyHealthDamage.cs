using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthDamage : MonoBehaviour
{
    public int maxhealth = 2;
    public int currenthealth;
    public int health;

    public EnemyHealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        Slider slider = GetComponent<Slider>();
        currenthealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
    }

     
   void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Score") 
        {
            TakenDamage(1);
            Debug.Log("damage taken by enemy from " + collision.gameObject.tag);
            Destroy(collision.gameObject);
        }
    }

    public void TakenDamage(int Damage)
    {
        currenthealth -= Damage;

        healthBar.SetHealth(currenthealth);
    }

   
}
