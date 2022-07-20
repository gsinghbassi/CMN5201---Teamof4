using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViolinAttack : MonoBehaviour
{
    private int violin = 0;
    private bool inventoryViolin = false;
    [SerializeField] private Text violintext;
    [SerializeField] Transform attackingPointRight, attackingPointLeft, attackingPointUp, attackingPointDown;
    [SerializeField] GameObject musicScorePrefab;
    [SerializeField] GameObject ViolinIcon;
    private int counter=0;
    private bool isInInventory=false;

    public CharacterController myCharacterController;

    [SerializeField] private AudioSource violinPickUpSFX;

    private void Start()
    {
        ViolinIcon.SetActive(false);
    }
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
        if (counter == 300000)
        {
            inventoryViolin = false;
            ViolinIcon.SetActive(false);
            isInInventory = false;
        }
    }
    void Shoot()
    {
        if (myCharacterController.myDirection == CharacterController.Direction.right)
        {
            Instantiate(musicScorePrefab, attackingPointRight.position, attackingPointRight.rotation);
            counter++;
        }
        if (myCharacterController.myDirection == CharacterController.Direction.left)
        {
            Instantiate(musicScorePrefab, attackingPointLeft.position, attackingPointLeft.rotation);
            counter++;
        }
        if (myCharacterController.myDirection == CharacterController.Direction.up)
        {
            Instantiate(musicScorePrefab, attackingPointUp.position, attackingPointUp.rotation);
            counter++;
        }
        if (myCharacterController.myDirection == CharacterController.Direction.down)
        {
            Instantiate(musicScorePrefab, attackingPointDown.position, attackingPointDown.rotation);
            counter++;
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isInInventory == false)
        {

            if (collision.gameObject.tag == "Violin")
            {
                violinPickUpSFX.Play();
                Destroy(collision.gameObject);
                violin++;
                violintext.text = "Violin: " + violin;
                inventoryViolin = true;
                ViolinIcon.SetActive(true);
                counter = 0;
                isInInventory = true;
                G_GameManager.Obj_violincollection = true;
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

