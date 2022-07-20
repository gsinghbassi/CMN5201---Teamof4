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
    float damagedelay;

    Color healthy;
    Color damage;
    public SpriteRenderer Doll;

    public GameObject gameOverScreen;
    AudioSource PlayerAudioController;

    //Checkpoint
    public Transform Checkpoint;
    public AudioClip CheckPointSound;

    // Start is called before the first frame update
    void Start()
    {
        Checkpoint = null;
        healthy = new Color(1f, 1f, 1f, 1f);
        damage = new Color(1f, 0f, 0f, 1f);

        //Doll = GetComponent<SpriteRenderer>();
        Doll.color = healthy;

        Slider slider = GetComponent<Slider>(); 
        currenthealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
        PlayerAudioController = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hunter")
        {
            TakenDamage(1);
            Doll.color = damage;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hunter")
        {
            Doll.color = healthy;
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Light")
        {
            TakenDamage(1);
            Doll.color = damage;
        }

        if (collision.gameObject.tag == "CheckPoints")
        {
            Checkpoint = collision.gameObject.transform;
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            collision.gameObject.transform.Find("CheckpointGFX").gameObject.SetActive(true);
            PlayerAudioController.PlayOneShot(CheckPointSound);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Light")
        {
            Doll.color = healthy;
        }

    }


    public void TakenDamage(int Damage)
    {
        if (Time.time > damagedelay)
        {
            currenthealth -= Damage;
            healthBar.SetHealth(currenthealth);
            damagedelay = Time.time + 1f;
        }

    }

    public void CheckpointRestart()
    {
        health = maxhealth;
        currenthealth = maxhealth;
        transform.position = Checkpoint.position;
        PlayerAudioController.PlayOneShot(CheckPointSound);

    }



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



    IEnumerator HealthySkin()
    {
        yield return new WaitForSeconds(5f);
        Doll.color = healthy;
    }

}
