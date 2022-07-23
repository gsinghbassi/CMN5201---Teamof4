using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MansionPathIndicator : MonoBehaviour
{ 
    [SerializeField] private Text mansionText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            mansionText.text = "Path to the Mansion";
        }
    }
}
