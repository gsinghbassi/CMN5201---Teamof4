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
    public enum Direction { up, down, left, right };
    public Direction myDirection;


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
            myDirection = Direction.right;
        }
        else if (Input.GetAxis("Vertical") < 0.0f)
        {
            spriteRenderer.sprite = down;
            myDirection = Direction.down;
        }
        else if (Input.GetAxis("Horizontal") < 0.0f)
        {
            spriteRenderer.sprite = left;
            myDirection = Direction.left;
        }
        else if (Input.GetAxis("Vertical") > 0.0f)
        {
            spriteRenderer.sprite = up;
            myDirection = Direction.up;
        }
    }

    void DollMovement()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), (Input.GetAxis("Vertical")) / 1.5f);
        DollRigidbody.velocity = direction * speed;

    }

    void DirectionAttack()
    {
        if (spriteRenderer.sprite == up && Input.GetAxis("Vertical") < 0.0f)
        {
            GetComponent<BanjoAttack>();
            GetComponent<GuitarAttack>();
            GetComponent<ViolinAttack>();
            
        }
        if (spriteRenderer.sprite == down && Input.GetAxis("Vertical") > 0.0f) 
        {
            GetComponent<BanjoAttack>();
            GetComponent<GuitarAttack>();
            GetComponent<ViolinAttack>();
        }
        if (spriteRenderer.sprite = left)
        {

        }
        if (spriteRenderer.sprite = right)
        {

        }
    }
}