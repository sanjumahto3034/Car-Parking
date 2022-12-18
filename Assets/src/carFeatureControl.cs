using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carFeatureControl : MonoBehaviour
{
    public Wheel wheel;
    public Lights _light;

}



[System.Serializable]
 public class Wheel{
    public GameObject frontLeftWheel;
    public GameObject frontRightWheel;  
    public GameObject backLeftWheel;
    public GameObject backRightWheel;
   }

[System.Serializable]
public class Lights{
    public GameObject frontLeftLight;
    public GameObject frontRightLight;
    public GameObject backLeftLight;
    public GameObject backRightLight;

    void Awake(){
        bool _bool = false;
        backLeftLight.SetActive(_bool);
        backRightLight.SetActive(_bool);
        frontLeftLight.SetActive(_bool);
        frontRightLight.SetActive(_bool);
    }
    public void frontLight(bool _bool){
        frontLeftLight.SetActive(_bool);
        frontRightLight.SetActive(_bool);
    }
     public void backLight(bool _bool){
        backLeftLight.SetActive(_bool);
        backRightLight.SetActive(_bool);
    }
}
