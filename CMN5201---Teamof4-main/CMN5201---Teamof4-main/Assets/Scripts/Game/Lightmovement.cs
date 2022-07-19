using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightmovement : MonoBehaviour
{
    float[] positions;
    public GameObject[] lights;
    // Start is called before the first frame update
    void Start()
    {
        positions[2] = transform.position.x;
        positions[3] = transform.position.y;

        lights[0].SetActive(false);
        lights[1].SetActive(false);
        lights[2].SetActive(false);
        lights[3].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        positions[0] = transform.position.x;
        positions[1] = transform.position.y;
        if (positions[0] > positions[2])
        {
            lights[1].SetActive (true);
            lights[0].SetActive(false);
            lights[2].SetActive(false);
            lights[3].SetActive(false);
            positions[2] = positions[0];
        }
        if (positions[0] < positions[2])
        {
            lights[3].SetActive (true);
            lights[0].SetActive(false);
            lights[1].SetActive(false);
            lights[2].SetActive(false);
            positions[2] = positions[0];
        }
        if (positions[1] > positions[3])
        {
            lights[0].SetActive (true);
            lights[1].SetActive(false);
            lights[2].SetActive(false);
            lights[3].SetActive(false);
            positions[3] = positions[1];
        }
        if (positions[1] < positions[3])
        {
            lights[2].SetActive (true);
            lights[0].SetActive(false);
            lights[1].SetActive(false);
            lights[3].SetActive(false);
            positions[3] = positions[1];
        }
    }
}
