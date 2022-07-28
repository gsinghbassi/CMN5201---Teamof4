using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHealthDamage : MonoBehaviour
{
    public int maxhealth = 50;
    public int currenthealth;
    public int health;
    public bool huntersleeping;
    public AudioClip DamageSound;
    AudioSource EnemySoundController;
    public EnemyHealthBar healthBar;
    private int maxEnemies = 6;

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
            maxEnemies--;
        }

        if(maxEnemies == 0)
        {
            G_GameManager.Obj_huntersleep = true;
            SceneManager.LoadScene("GameCleared");

        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      
    }

    public void TakenDamage(int Damage)
    {
        currenthealth -= Damage;  //check if health is 0, if so, set sleeping flag to true, and set the art to sleeping

        healthBar.SetHealth(currenthealth);
        EnemySoundController.PlayOneShot(DamageSound);
        EnemySoundController.SetScheduledEndTime(1f);

    }

   
}
