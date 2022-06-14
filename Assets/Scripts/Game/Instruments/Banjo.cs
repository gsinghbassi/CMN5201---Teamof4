using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Banjo : MonoBehaviour
{
    private int banjo=0;
    [SerializeField] private Text banjotext;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Banjo")
        {
            Destroy(collision.gameObject);
            banjo++;
            banjotext.text = "Banjo: " + banjo;
        }
    }
}
