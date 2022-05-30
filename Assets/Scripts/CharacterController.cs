using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Rigidbody2D DollRigidbody;
    public float speed;
    Vector2 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        DollRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        DollMovement();
    }

    void DollMovement()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), (Input.GetAxis("Vertical")) / 1.5f);
        DollRigidbody.velocity = direction * speed;

    }
}