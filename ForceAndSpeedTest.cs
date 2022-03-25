using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceAndSpeedTest : MonoBehaviour {

	
	// Use this for initialization
	private Rigidbody rigidbody;
	private double speed;
	private double lastspeed=0;
	private double a;
	private bool flag = false;
	void Start () {
		Debug.Log("开始位置"+this.GetComponent<Transform>().position);

		rigidbody= this.transform.GetComponent<Rigidbody>();
		//每秒显示一次速度加速度
		//InvokeRepeating("recordStatu", 0f,1f);
	}

	private void FixedUpdate()
	{
		// if (Input.GetKeyDown(KeyCode.F))
		// {
		// 	flag = true;
		//
		// }
		//
		// if (flag)
		// {
		// 	//rigidbody.AddForce(Vector3.right*10.0f);
		// 	//double f=this.GetComponent<ConstantForce>().force.magnitude;
		// 	
		// 	//Debug.Log(f);
		// 	//Debug.Log("FFFFFFFFFFFFFFFFFFFF");
		// }
		//Debug.Log("FFFFFFFFFFFFFFFFFFFF");
		speed = rigidbody.velocity.magnitude;
		a = (speed - lastspeed) / 0.02;
		lastspeed = speed;
		Debug.Log("速度"+speed.ToString());
		 Debug.Log("质量"+rigidbody.mass);
		 Debug.Log(Physics.gravity);
		 Debug.Log("加速度" + a.ToString());
	}

	// Update is called once per frame
	void Update () {
		//按键施加力
		
	}

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
