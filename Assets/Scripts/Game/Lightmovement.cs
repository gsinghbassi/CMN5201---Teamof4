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
        lights[2].SetActive(false);
        lights[3].SetActive(false);

        if (positions.x < 1)
        {
            //right light
            lights[1].SetActive(true);
        }
        if (positions.x > 1)
        {
            //left light
            lights[3].SetActive(true);
        }
        if (positions.y < 1)
        {
            //down light
            lights[2].SetActive(true);
        }
        if (positions.y > 1)
        {
            //up light
            lights[0].SetActive(true);
        }

    }
}
