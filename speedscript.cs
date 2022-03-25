using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedscript : MonoBehaviour {


    public Rigidbody targetObj;
    public TextMesh inTimeSpeed;
    public TextMesh maxSpeed;
    public TextMesh aT;

    private double max=0;
    private double min=0;
    
    private double lastSpeed=0;
    private double a = 0;

    private bool flag = true;
    // Use this for initialization
	void Start () {

    }

	private void FixedUpdate()
	{
		//加速度计算尝试
		double speed = targetObj.velocity.magnitude;
		//第一次刷新初始化
		if (flag)
		{
			flag = false;
			a = 0;
			lastSpeed = speed;
		}
		else
		{
			a = (speed - lastSpeed) / 0.02;
			Debug.Log(lastSpeed);
			Debug.Log(speed);
			Debug.Log(a);
			Debug.Log("----------------------------");
			lastSpeed = speed;
			
		}
		aT.text=Math.Round(a,2).ToString();
		
		
	}

	// Update is called once per frame
	void Update () {

    	double speed = targetObj.velocity.magnitude;
        speed=Math.Round(speed,2);
        inTimeSpeed.text = speed.ToString();
        if (speed >= max)
	        max = speed;
        maxSpeed.text = max.ToString();
        
        
        
	}
}
