using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthDamage : MonoBehaviour
{
    public int maxhealth = 2;
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
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            TakenDamage(1);
        }
        /*TakenDamage(1);*/
    }

    public void TakenDamage(int Damage)
    {
        currenthealth -= Damage;

        healthBar.SetHealth(currenthealth);
    }
}
