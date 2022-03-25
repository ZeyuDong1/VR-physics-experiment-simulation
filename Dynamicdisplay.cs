using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dynamicdisplay : MonoBehaviour {
    public Text DynamicDisplayText;
    //实时获取速度和加速度
    private void FixedUpdate()
    {
        DynamicDisplayText.text = "";
        if (GameObject.FindWithTag("Cube") != null)
        {
            double a = GameObject.FindWithTag("Cube").GetComponent<GetSpeed>().getA();
            double speed = GameObject.FindWithTag("Cube").GetComponent<GetSpeed>().getSpeed();
            DynamicDisplayText.text += "速度:" + Math.Round(speed, 2).ToString();
            DynamicDisplayText.text += "\r\n";
            DynamicDisplayText.text += "加速度" + Math.Round(a, 1).ToString();
        }
    

       
        
    }
}
