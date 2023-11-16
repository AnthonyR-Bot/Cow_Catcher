using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public GameObject carGameObj;
    public Rigidbody2D carRigidBody;
    public float velocity = 0;
    public float maxPosVel = 10;
    public float maxNegVel = (float)-5;


    public Vector2 carDirection;
    public float spriteT = 0;
    //public float prevTheta = 0;
    public float theta = 90;
    public float x = 0;
    public float y = 1;
    public float turningRate = (float)0.5;


    // Start is called before the first frame update
    void Start()
    {
        carDirection = new Vector2(0, 1);
    }

    // Update is called once per frame
    void Update()
    {

        //Forwards and Backwards acceleration ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        if (Input.GetKey(KeyCode.W))
        {
            if (velocity < maxPosVel)
            {
                velocity += (float)(0.05);
            }
        } else {
            //after a few seconds slow down(not yet implemented add later);
            if(velocity > 0)
            {
                velocity -= (float)(0.025);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (velocity > maxNegVel)
            {
                velocity -= (float)(0.025);
            }
        }
        else
        {
            //after a few seconds slow down(not yet implemented add later);
            if (velocity < 0)
            {
                velocity += (float)(0.025);
            }
        }
        /*if(velocity > maxPosVel){
            velocity = maxPosVel;
        }
        if(velocity < maxNegVel){
            velocity = maxNegVel;
        }*/



        //Turning~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        if (Input.GetKey(KeyCode.A)) {
            spriteT = turningRate;
            theta += turningRate;
        } else if (Input.GetKey(KeyCode.D)) {
            spriteT = -turningRate;
            theta -= turningRate;
        }
        else {
            spriteT = 0;
        }

        //spriteT = theta - prevTheta;
        //prevTheta = theta;
        x = (float)Math.Cos(theta * Math.PI/180);
        y = (float)Math.Sin(theta * Math.PI/180);
        carDirection.x = x; carDirection.y = y;
        carGameObj.transform.Rotate(0, 0, spriteT, Space.Self);


        carRigidBody.velocity = velocity * carDirection;
        
    }
}
