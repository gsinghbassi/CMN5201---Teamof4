using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightmovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 positions;
    public GameObject[] lights;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lights[0].SetActive(false);
        lights[1].SetActive(false);
        lights[2].SetActive(false);
        lights[3].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        positions = new Vector2(rb.velocity.x, rb.velocity.y);

        lights[0].SetActive(false);
        lights[1].SetActive(false);
        lights[2].SetActive(false);
        lights[3].SetActive(false);

        if (positions.x > 0)
        {
            //right light
            lights[1].SetActive(true);
            Debug.Log("right");
        }
        if (positions.x < 0)
        {
            //left light
            lights[3].SetActive(true);
        }
        if (positions.y < 0)
        {
            //down light
            lights[2].SetActive(true);
            Debug.Log("down");
        }
        if (positions.y > 0)
        {
            //up light
            lights[0].SetActive(true);
        }

    }
}
