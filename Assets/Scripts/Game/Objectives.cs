using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objectives : MonoBehaviour
{
    public GameObject objectives;
    public bool isOn;
    public bool isOff;
    public GameObject toggleForObjective1;
    public GameObject toggleForObjective2;
    public GameObject toggleForObjective3;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Guitar")
        {
            isOn = true;
            Debug.Log("The Guitar has been picked up !!!");

        }
        else
        {
            isOn = false;
            Debug.Log("The Guitar has not been picked up !!!");
        }
    }

}
