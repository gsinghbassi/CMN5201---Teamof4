using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BanjoAttack : MonoBehaviour
{
    private int banjo = 0;
    private bool inventoryBanjo = false;
    [SerializeField] private Text banjotext;
    [SerializeField] Transform attackingPointRight, attackingPointLeft, attackingPointUp, attackingPointDown;
    [SerializeField] GameObject musicScorePrefab;
    private int counter = 0;
    [SerializeField] GameObject banjoIcon;
    private bool isInInventory = false;

    public CharacterController myCharacterController;

    [SerializeField] private AudioSource banjoPickUpSFX;

    public AudioSource audioSource;
    public AudioClip[] audioClipArray;

    private void Start()
    {
        banjoIcon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inventoryBanjo == true)
        {

            if (Input.GetButtonDown("Fire1")) //Press the left CTRL
            {
                Shoot();
                counter++;
            }
        }
        if (counter == 2) // TODO will do more damage later
        {
            inventoryBanjo = false;
            banjoIcon.SetActive(false);
            isInInventory = false;
        }

    }
    void Shoot()
    {
        if(myCharacterController.myDirection == CharacterController.Direction.right)
        {
            Instantiate(musicScorePrefab, attackingPointRight.position, attackingPointRight.rotation);
        }
        if (myCharacterController.myDirection == CharacterController.Direction.left)
        {
            Instantiate(musicScorePrefab, attackingPointLeft.position, attackingPointLeft.rotation);
        }
        if (myCharacterController.myDirection == CharacterController.Direction.up)
        {
            Instantiate(musicScorePrefab, attackingPointUp.position, attackingPointUp.rotation);
        }
        if (myCharacterController.myDirection == CharacterController.Direction.down)
        {
            Instantiate(musicScorePrefab, attackingPointDown.position, attackingPointDown.rotation);
        }



    }

    AudioClip RandomClip()
    {
        return audioClipArray[Random.Range(0, audioClipArray.Length)];
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isInInventory == false)
        {

            if (collision.gameObject.tag == "Banjo")
            {
                audioSource.PlayOneShot(RandomClip());
                banjoPickUpSFX.Play();
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
            collision.gameObject.GetComponent<EnemyHealthDamage>().TakenDamage(10);
        }

       
        
    }
}
