using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichaelJackson : MonoBehaviour
{
    GameObject MichaelJacksonAnimation;
    int activatemichaelcounter;
    // Start is called before the first frame update
    void Start()
    {
        MichaelJacksonAnimation = transform.GetChild(0).gameObject;
        activatemichaelcounter = 0;
        MichaelJacksonAnimation.SetActive(false);
        //  Destroy(gameObject, 10.7f);
    }

    // Update is called once per frame
    void Update()
    {
        if(activatemichaelcounter==10)
        {
            MichaelJacksonAnimation.SetActive(true);
            StartCoroutine(StopMichael());

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Score")
        {
            activatemichaelcounter++;            
        }
    }

    IEnumerator StopMichael()
    {
        yield return new WaitForSeconds(10.7f);
        MichaelJacksonAnimation.SetActive(false);
    }
}
