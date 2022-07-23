using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PumpkinFieldIndicator : MonoBehaviour
{
    [SerializeField] private Text pumpkinFieldText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            pumpkinFieldText.text = "Pumpkin Field";
        }
    }

}
