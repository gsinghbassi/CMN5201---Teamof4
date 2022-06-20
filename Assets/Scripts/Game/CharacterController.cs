using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Rigidbody2D DollRigidbody;
    public float speed;
    Vector2 direction;
    SpriteRenderer spriteRenderer;
    public Sprite left, right, up, down;


    // Start is called before the first frame update
    void Start()
    {
       DollRigidbody = GetComponent<Rigidbody2D>();
       spriteRenderer  = GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        DollMovement();

        if (Input.GetAxis("Horizontal") > 0.0f)
        {
            spriteRenderer.sprite = right;
        }
        else if (Input.GetAxis("Vertical") < 0.0f)
        {
            spriteRenderer.sprite = down;
        }
        else if (Input.GetAxis("Horizontal") < 0.0f)
        {
            spriteRenderer.sprite = left;
        }
        else if (Input.GetAxis("Vertical") > 0.0f)
        {
            spriteRenderer.sprite = up;
        }
    }

    void DollMovement()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), (Input.GetAxis("Vertical")) / 1.5f);
        DollRigidbody.velocity = direction * speed;

    }
}