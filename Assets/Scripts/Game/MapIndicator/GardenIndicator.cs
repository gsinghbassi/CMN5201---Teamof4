using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GardenIndicator : MonoBehaviour
{
    [SerializeField] private Text gardenIndicator;
    // Start is called before the first frame update
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            gardenIndicator.text = "Garden of Curiosities";
        }
    }
}