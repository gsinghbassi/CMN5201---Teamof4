using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

    public int maxhealth = 8;
    public int currenthealth;
    public int health;

    private bool gameOver;

    public HealthBar healthBar;

    public GameObject gameOverScreen;

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
        if (collision.gameObject.tag == "Hunter")
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

<<<<<<< HEAD


=======
>>>>>>> 54f2b1354d687bcacc4ecd415f01090905b6ad39
    /* private void OnCollisionEnter2D(Collision2D collision)
     {
         if (collision.gameObject.tag == "Player")
         {
             health -= currenthealth;
         }
     }*/
<<<<<<< HEAD

    private void Update()
    {
        if  (currenthealth == 0)
        {
            gameOver = true;
            StartCoroutine(DisplayGameOver());
        }
    }

    IEnumerator DisplayGameOver()
    {
        yield return new WaitForSeconds(0.5f);
        gameOverScreen.SetActive(true);
    }

=======
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Light")
        {
            TakenDamage(1);
        }
        /*TakenDamage(1);*/
    }
>>>>>>> 54f2b1354d687bcacc4ecd415f01090905b6ad39
}
