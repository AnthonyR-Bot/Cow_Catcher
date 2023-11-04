using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraScript : MonoBehaviour{
    private Quaternion r;
    void Start()
    {
        r = this.transform.rotation;
    }
 
    void Update()
    {
        this.transform.rotation = r;
    }
}