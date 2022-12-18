using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform targate;
    public Vector3 offset;
    void Start()
    {
        
        transform.position = targate.position - offset;
        
    }
    void FixedUpdate(){
        transform.position = targate.position - offset;
    }

  
}
