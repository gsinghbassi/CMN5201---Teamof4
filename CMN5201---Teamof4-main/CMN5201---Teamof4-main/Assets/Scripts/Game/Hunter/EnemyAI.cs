using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] Transform[] patrolPoints;
    private int patrolPointIndex;
    [SerializeField] float speed = 7f;
    [SerializeField] float idleTime = 2f;
    [SerializeField] float patrolDistance = 1f;
    [SerializeField] bool isWaiting = false;
    SpriteRenderer graphics;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        graphics = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector2 moveDirection = (patrolPoints[patrolPointIndex].position - transform.position).normalized*speed;
        //Move to destination
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        graphics.flipX = rb.velocity.x > 0;
       
        //Check the destination
        if (Vector2.Distance(transform.position, patrolPoints[patrolPointIndex].position) < patrolDistance)
        {
            //At patrol point
            StartCoroutine(Wait());
        }
        //Wait before moving again
        

    }
    IEnumerator Wait()
    {
        if (isWaiting)
            yield break;
        isWaiting = true;
        yield return new WaitForSeconds(idleTime); //wait for few seconds

        patrolPointIndex++;

        if (patrolPointIndex > patrolPoints.Length - 1)
            patrolPointIndex = 0;
        isWaiting=false;


    }
}
