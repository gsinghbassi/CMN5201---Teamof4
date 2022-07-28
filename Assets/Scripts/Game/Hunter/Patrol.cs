using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [Header ("Patrol Points")]
    [SerializeField] Transform leftEdge;
    [SerializeField] Transform rightEdge;

    [Header("Enemy")]
    [SerializeField] Transform enemy;

    [Header("Movement parameters")]
    [SerializeField] float speed;
    private Vector3 initScale;
    private bool movingLeft;
    Animator anim;

    private void Awake()
    {
        initScale = enemy.localScale;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetBool("kill") == false)
        {


            if (movingLeft)
            {
                if (enemy.position.x <= rightEdge.position.x)
                    MoveInDirection(1);
                else
                {
                    DirectionChange();
                }


            }

            else
            {
                if (enemy.position.x >= leftEdge.position.x)
                    MoveInDirection(-1);
                else
                {
                    DirectionChange();
                }
            }
            MoveInDirection(1);
        }
    }

    private void DirectionChange()
    {
        movingLeft=!movingLeft;
    }
    private void MoveInDirection(int _direction)
    {
        enemy.localScale= new Vector3(Mathf.Abs(initScale.x) * _direction, initScale.y, initScale.z);


        enemy.position = new Vector3 (enemy.position.x +Time.deltaTime * _direction *speed,enemy.position.y,enemy.position.z);

    }
}
