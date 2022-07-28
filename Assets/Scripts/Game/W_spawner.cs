using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_spawner : MonoBehaviour
{
    public int x;
    public GameObject[] instuments;

    // Start is called before the first frame update
    void Start()
    {
        if (x == 3)
        {
            int random = Random.Range(0, instuments.Length);
            Instantiate(instuments[random], transform.position, transform.rotation);
        }
        else
        {
            Instantiate(instuments[x], transform.position, transform.rotation);
        }
    }
}
