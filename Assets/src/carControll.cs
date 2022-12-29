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
        
        // horizontalInput = Input.GetAxis("Vertical");
        // verticleInput = Input.GetAxis("Horizontal");
        // Debug.Log("Horizontal Axis -> "+horizontalInput+" : \nVertical Input -> "+verticleInput);
        getWheelCollider();
        allWheelAnimationControll();
    }   
    public void horizontalFunc(float value){
        horizontalInput = value;
        Debug.Log("Mobile Class Called");
       
    }
    public void verticleFunc(float value){
        verticleInput = value;
        Debug.Log("Mobile Class Called");

    }
    private void getWheelCollider(){
        // if(breakForce != 0)return;

        accelarateVehicle(left_fWheelCollider);
        accelarateVehicle(right_fWheelCollider);
        accelarateVehicle(left_bWheelCollider);
        accelarateVehicle(right_bWheelCollider);
        
        stearVehicleAngle(left_fWheelCollider);
        stearVehicleAngle(right_fWheelCollider);

        // breaks
        // breakForce = (Input.GetKey(KeyCode.Space))?2000:0;
        // applyBreaksOnVehicle(left_fWheelCollider);
        // applyBreaksOnVehicle(right_fWheelCollider);
        // applyBreaksOnVehicle(left_bWheelCollider);
        // applyBreaksOnVehicle(right_bWheelCollider);
    }

    public void allWheelBreakApply(float _breakForce){
        breakForce = _breakForce;
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
