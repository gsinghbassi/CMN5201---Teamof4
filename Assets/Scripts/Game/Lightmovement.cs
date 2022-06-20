using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightmovement : MonoBehaviour
{
    float hold;
    bool right;
    float pos;
    // Start is called before the first frame update
    void Start()
    {
        hold = transform.position.x;
        if (right == true)
        {
            transform.localPosition = new Vector3(-2.31f, -0.28f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else
        {
            transform.localPosition = new Vector3(2.31f, -0.28f, 0);
            transform.rotation = Quaternion.Euler(0,0,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x > hold)
        {
            transform.localPosition = new Vector3(0.53f, -0.006f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else
        {
            transform.localPosition = new Vector3(-0.53f, -0.06f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
