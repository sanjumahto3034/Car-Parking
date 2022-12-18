using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mobileController : MonoBehaviour
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
