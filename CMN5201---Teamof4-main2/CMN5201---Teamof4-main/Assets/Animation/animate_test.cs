using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate_test : MonoBehaviour
{
    Animator anim;
    public int A;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        if (A == 1)
        {
            anim.SetBool("down", true);
        }
        if (A == 2)
        {
            anim.SetBool("up", true);
        }
        if (A == 3)
        {
            anim.SetBool("side", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
