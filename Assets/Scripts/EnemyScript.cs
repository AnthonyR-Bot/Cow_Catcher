using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject MC;
    private Vector3 target;
    private Vector3 me;
    public Quaternion enemyDirection;
    // Start is called before the first frame update
    void Start()
    {
        //enemyDirection = new Vector2(0, 1);
        enemyDirection = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        target = MC.transform.position;
        me = this.gameObject.transform.position;
        enemyDirection = Quaternion(target.x, target.y);
        this.transform.rotation = enemyDirection;
    }
}