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
    [SerializeField] GameObject musicScorePrefabRight;
    [SerializeField] GameObject musicScorePrefabLeft;
    [SerializeField] GameObject musicScorePrefabTop;
    [SerializeField] GameObject musicScorePrefabDown;
    
   

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
            Instantiate(musicScorePrefabRight, attackingPointRight.position, attackingPointRight.rotation);
            
            counter++;
        }
        if (myCharacterController.myDirection == CharacterController.Direction.left)
        {
            
            Instantiate(musicScorePrefabLeft, attackingPointLeft.position, attackingPointRight.rotation);
            
            counter++;
        }
        if (myCharacterController.myDirection == CharacterController.Direction.up)
        {
            Instantiate(musicScorePrefabTop, attackingPointUp.position, attackingPointRight.rotation);
            
            counter++;
        }
        if (myCharacterController.myDirection == CharacterController.Direction.down)
        {
            Instantiate(musicScorePrefabDown, attackingPointDown.position, attackingPointRight.rotation);
           
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

