using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthDamage : MonoBehaviour
{
    public int maxhealth = 50;
    public int currenthealth;
    public int health;
    public bool huntersleeping;
    public AudioClip DamageSound;
    AudioSource EnemySoundController;
    public EnemyHealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        Slider slider = GetComponent<Slider>();
        currenthealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
        EnemySoundController = GetComponent<AudioSource>();
    }

     
   void Update()
    {
        if (currenthealth<=0 && !huntersleeping)
        {
            G_GameManager.Obj_huntersleep = true;
            huntersleeping=true;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      
    }

    public void TakenDamage(int Damage)
    {
        currenthealth -= Damage;

        healthBar.SetHealth(currenthealth);
        EnemySoundController.PlayOneShot(DamageSound);
        EnemySoundController.SetScheduledEndTime(1f);

    }

   
}
