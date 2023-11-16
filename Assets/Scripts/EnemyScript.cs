using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public GameObject MC;
    public GameObject me;
    public Vector2 target;
    public Vector2 myPos;
    public Vector2 enemyDirection;
    private double angle;
    private float turningRate = 0.25f; 
    private float myRot;
    private float spriteT = 0;
    private float theta;
    private float x, y;
    // Start is called before the first frame update
    void Start()
    {
        enemyDirection = new Vector2(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        target = MC.transform.position;
        myPos = me.transform.position;
        if(target.x != myPos.x){
            angle = (Math.Atan((target.y-myPos.y)/(target.x-myPos.x)) * 180/Math.PI) + 90;
        }
        else if(target.y < myPos.y){
            angle = 270;
        }
        else{
            angle = 90;
        }
        if(angle < 0){
            angle += 360;
        }
        //me.transform.Rotate(0, 0, (float)0.1, Space.Self);
        if(myPos.x > target.x){
            angle += 180;
        }

        myRot = me.transform.eulerAngles.z;
        if(myRot < angle && !(myRot < 90 && angle > 270) || (myRot > 270 && angle < 90)){
            spriteT = turningRate;
            theta += turningRate;
        }else if(myRot > angle || (myRot < 90 && angle > 270)){
            spriteT = -turningRate;
            theta -= turningRate;
        }else{
            spriteT = 0;
        }
        
        //Debug.Log("MyRot: "+ myRot + "\n");
        //Debug.Log("angle: " + angle + "\n\n");
        y = -(float)Math.Cos(theta * Math.PI/180);
        x = (float)Math.Sin(theta * Math.PI/180);
        enemyDirection.x = x; enemyDirection.y = y;
        me.transform.Rotate(0, 0, spriteT, Space.Self);
        rigidBody.velocity = 3 * enemyDirection;
    }
}