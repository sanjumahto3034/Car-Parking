using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class carControll : MonoBehaviour
{
    public float motroTork;
    public float breakForce;
    public float maxStearing;

    private float horizontalInput;
    private float verticleInput;
    public WheelCollider left_fWheelCollider;
    public WheelCollider right_fWheelCollider;
    public WheelCollider left_bWheelCollider;
    public WheelCollider right_bWheelCollider;

    public Transform left_fWheelTransform;
    public Transform right_fWheelTransform;
    public Transform left_bWheelTransform;
    public Transform right_bWheelTransform;

    void Start(){
        Application.targetFrameRate = 60;
    }
    void FixedUpdate(){
        // horizontalFunc(Input.GetAxis("Horizontal"));
        // verticleFunc(Input.GetAxis("Vertical"));
        getWheelCollider();
        allWheelAnimationControll();
    }   
    public void horizontalFunc(float value){
        horizontalInput = value;
       
    }
    public void verticleFunc(float value){
        verticleInput = value;
        
    }
    private void getWheelCollider(){
        accelarateVehicle(left_fWheelCollider);
        accelarateVehicle(right_fWheelCollider);
        accelarateVehicle(left_bWheelCollider);
        accelarateVehicle(right_bWheelCollider);
        
        stearVehicleAngle(left_fWheelCollider);
        stearVehicleAngle(right_fWheelCollider);



        // breaks
        breakForce = (Input.GetKey(KeyCode.Space))?2000:0;
        applyBreaksOnVehicle(left_fWheelCollider);
        applyBreaksOnVehicle(right_fWheelCollider);
        applyBreaksOnVehicle(left_bWheelCollider);
        applyBreaksOnVehicle(right_bWheelCollider);
    }





    private void accelarateVehicle(WheelCollider _wheel){
        _wheel.motorTorque = motroTork * horizontalInput;
    }
    private void stearVehicleAngle(WheelCollider _wheel){
        _wheel.steerAngle = maxStearing * verticleInput;
    }
    private void applyBreaksOnVehicle(WheelCollider _wheel){
        _wheel.brakeTorque = breakForce;
    }



    private void allWheelAnimationControll(){
        wheelAnimation(left_fWheelCollider,left_fWheelTransform);
        wheelAnimation(right_fWheelCollider,right_fWheelTransform);
        wheelAnimation(left_bWheelCollider,left_bWheelTransform);
        wheelAnimation(right_bWheelCollider,right_bWheelTransform);
    }
    private void wheelAnimation(WheelCollider _wheelCollider, Transform _wheelTransform){
        Vector3 pos;
        Quaternion rot;
        _wheelCollider.GetWorldPose(out pos,out rot);

        _wheelTransform.rotation = rot;
        _wheelTransform.position = pos;

    }


}
[System.Serializable]
public class WheelColiderClass{

}
[System.Serializable]
public class WheelTransformClass{
    public Transform left_fWheel;
    public Transform right_fWheel;
    public Transform left_bWheel;
    public Transform right_bWheel;
}
    /*
    public float tork = 2000000f;
    public Vector3 tyreRotation;
    public List<WheelCollider> wheels;
    public List<WheelCollider> stearWheel;
    public List<Transform> stearWheelTransform;

    public float maxTurn = 20;

    void Awake(){
      
    }

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
            rotateWheels(wheel);

        }
    }

    public void rotateWheels(WheelCollider _wheel){
        foreach(Transform t_wheel in stearWheelTransform){
            Vector3 pos;
            Quaternion rot;
            _wheel.GetWorldPose(out pos,out rot);
            t_wheel.rotation = rot;
            t_wheel.position = pos;
        }
    }
    

}
*/
