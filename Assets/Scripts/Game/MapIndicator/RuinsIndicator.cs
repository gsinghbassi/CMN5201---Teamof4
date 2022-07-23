using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuinsIndicator : MonoBehaviour
{
    [SerializeField] private Text ruinsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            ruinsText.text = "Ruins";
        }
    }

}
