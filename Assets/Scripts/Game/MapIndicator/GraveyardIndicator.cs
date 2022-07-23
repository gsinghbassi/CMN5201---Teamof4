using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraveyardIndicator : MonoBehaviour
{
    [SerializeField] private Text graveyardText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            graveyardText.text = "Graveyard";
        }
    }

}
