using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class carControll : MonoBehaviour
{
    public float tork = 2000000f;
    public Vector3 tyreRotation;
    public List<WheelCollider> wheels;
    public List<WheelCollider> stearWheel;

    public float maxTurn = 20;


    void Start(){
        Application.targetFrameRate = 60;
    }

    void FixedUpdate(){
        float accelaration = Input.GetAxis("Vertical");
        float stearing = Input.GetAxis("Horizontal");

        foreach(WheelCollider whel in wheels){
            accelrateVehile(accelaration);
            if(Input.GetKey(KeyCode.W)){
                whel.GetComponent<Transform>().Rotate(tyreRotation * Time.deltaTime);
            }
            else if(Input.GetKey(KeyCode.S)){
                whel.GetComponent<Transform>().Rotate(-tyreRotation * Time.deltaTime);
            }
        }
        foreach(WheelCollider wheel in stearWheel){
            stearVehile(stearing);
            bool isStraight = true;
             if(Input.GetKey(KeyCode.A)){
                isStraight = false;
                // wheel.GetComponent<Transform>().rotation = Quaternion.AngleAxis(-30, Vector3.up);
            }
            if(Input.GetKey(KeyCode.D)){
                isStraight = false;
                // wheel.GetComponent<Transform>().rotation = Quaternion.AngleAxis(30, Vector3.up);
            }
            if(isStraight){
                // wheel.GetComponent<Transform>().rotation = Quaternion.AngleAxis(0, Vector3.up);
            }
        }

    }
    public void accelrateVehile(float  _value){
        // Debug.Log("Calling ->"+_value);
        foreach(WheelCollider wheel in wheels){
            wheel.motorTorque = tork * Time.deltaTime * _value;
        }
    }


    public void stearVehile(float  _value){
        foreach(WheelCollider wheel in stearWheel){
            wheel.steerAngle = maxTurn * _value; 
        }
    }

    

}
