using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp_hunter : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit a hunter");
    }
}
