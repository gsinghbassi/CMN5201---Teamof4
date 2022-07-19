using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementdle : MonoBehaviour
{
    public enum stateMachine { countingUp, countingDown }
    public stateMachine counter;

    public float upperLimit, lowerLimit, speed;
    float offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        switch (counter)
        {
            case stateMachine.countingUp:
                //check if im at the limit
                if (offset >= upperLimit)
                {
                    counter = stateMachine.countingDown;
                }

                offset += speed * Time.deltaTime;


                break;

            case stateMachine.countingDown:
                //check if im at the limit
                if (offset <= lowerLimit)
                {
                    counter = stateMachine.countingUp;
                }
                offset -= speed * Time.deltaTime;


                break;

        }

        //apply the change
        transform.localPosition = new Vector3(transform.localPosition.x, offset, transform.localPosition.z);

    }
}

