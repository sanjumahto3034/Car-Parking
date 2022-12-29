using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mobileController : MonoBehaviour
{
    public carControll cc;
    
    void Start(){
        Application.targetFrameRate = 60;
    }

    public void AccelarateVehilce(float _value){
        cc.horizontalFunc(_value);
        Debug.Log(_value);
    }

    public void stearVehicle(float _value){
        cc.verticleFunc(_value);
    }

      public void applyBreaks(float _value){
        cc.allWheelBreakApply(_value);
    }


     public void restartGame(){
        SceneManager.LoadScene("gameScene");
    }


}
/*
{ 
   public float motorTork;
   public float breakForce;
   public _WheelClass wheelClass;

  
}

[System.Serializable]
 public class _WheelClass{
        public WheelCollider left_fWheel;
        public WheelCollider right_fWheel;       
        public WheelCollider left_bWheel;
        public WheelCollider right_bWheel;  
   }


{
    public carControll cc;
    private float stearValue = 0;
    private float accelrateValue = 0;

    void FixedUpdate(){
        cc.accelrateVehile(accelrateValue);
        cc.stearVehile(stearValue);
        Debug.Log("Callein--------------f " +accelrateValue+" "+stearValue+cc);
    }
    public void restartGame(){
        SceneManager.LoadScene("TestScene");
    }
    public void accelrate(){
        accelrateValue = 1;
        cc.accelrateVehile(1);
       
    }
    public void reverse(){
        accelrateValue = -1;
        cc.accelrateVehile(-1);
    }
    public void stearLeft(){
        stearValue = -1;
        cc.stearVehile(-1);
    }
     public void stearRight(){
        stearValue = 1;
        cc.stearVehile(1);
    }

    // -> UP handler
    public void accelrateUp(){
        accelrateValue = 0;
        cc.accelrateVehile(1);
        
    }
    public void reverseUp(){
        accelrateValue = 0;
        cc.accelrateVehile(-1);
    }
    public void stearLeftUp(){
        stearValue = 0;
        cc.stearVehile(-1);
    }
     public void stearRightUP(){
        stearValue = 0;
        cc.stearVehile(1);
    }
}
*/