using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViolinAttack : MonoBehaviour
{
    private int violin = 0;
    private bool inventoryViolin = false;
    [SerializeField] private Text violintext;
    [SerializeField] Transform attackingPoint;
    [SerializeField] GameObject musicScorePrefab;
    [SerializeField] GameObject ViolinIcon;
    private int counter=0;
    private bool isInInventory=false;

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
        if (counter == 3)
        {
            inventoryViolin = false;
            ViolinIcon.SetActive(false);
            isInInventory = false;
        }
    }
    void Shoot()
    {
        Instantiate(musicScorePrefab, attackingPoint.position, attackingPoint.rotation);
        counter++;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isInInventory == false)
        {

            if (collision.gameObject.tag == "Violin")
            {
                Destroy(collision.gameObject);
                violin++;
                violintext.text = "Violin: " + violin;
                inventoryViolin = true;
                ViolinIcon.SetActive(true);
                counter = 0;
                isInInventory = true;
            }
        }
    }
}

