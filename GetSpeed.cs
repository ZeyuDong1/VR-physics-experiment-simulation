using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class GetSpeed : MonoBehaviour {

	
	// Use this for initialization
	private Rigidbody rigidbody;
	private double speed;
	private double lastspeed=0;
	private double a;
	private List<double> Accelerate;
	private bool flag = false;

	public double getSpeed()
	{
		return speed;
	}

	public double getA()
	{
		return a;
	}

	public void resetA()
	{
		a = 0;
	}
	
	private void Awake()
	{
		Accelerate=new List<double>();

	}

	void Start () {
//		Debug.Log("开始位置"+this.GetComponent<Transform>().position);
		rigidbody= this.transform.GetComponent<Rigidbody>();
		//每秒显示一次速度加速度
		//InvokeRepeating("recordStatu", 0f,1f);
	}

	public List<double> getAccelerate()
	{
		return Accelerate;
	}
	private void FixedUpdate()
	{
		
		speed = rigidbody.velocity.magnitude;
		a = (speed - lastspeed) / 0.02;
		lastspeed = speed;
		if (a > 0)
		{
			//四舍五入
			Accelerate.Add(a);
		}
		showSpeed();
	}
	//每帧获取数据
	void showSpeed()
	{
		// print(speed);
		// Debug.Log("速度"+speed.ToString());
		// Debug.Log("质量"+rigidbody.mass);
		// Debug.Log("加速度" + a.ToString());
	}
	
	//每秒获取参数
	void recordStatu()
	{
		Debug.Log(this.GetComponent<Transform>().position);
		Debug.Log("速度"+speed.ToString());
		// Debug.Log("加速度" + a.ToString());
		Debug.Log("质量"+rigidbody.mass);
		Debug.Log("重力"+Physics.gravity);
		//Debug.Log(this.GetComponent<BoxCollider>().material.);
		Debug.Log("摩擦系数："+this.GetComponent<BoxCollider>().material.dynamicFriction);
		Debug.Log("摩擦系数结合方式："+this.GetComponent<BoxCollider>().material.frictionCombine);
		
		Debug.Log("加速度" + a.ToString());
		Debug.Log("**********************************");

	}
}
