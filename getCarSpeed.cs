using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getCarSpeed : MonoBehaviour {
	private Rigidbody rigidbody;
	// Use this for initialization


	private int flag = 0;
	private double speed;
	private double lastspeed=0;
	private Vector3 lastposition;

	private double a;
	private Vector3 startposition;
	
	void Start () {
		rigidbody = this.GetComponent<Rigidbody>();
		lastposition = this.transform.position;
		startposition = lastposition;
		
		
	}
	// Update is called once per frame
	void FixedUpdate () {
		
		speed = (this.transform.position.x - lastposition.x) / 0.02;
		using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"record3.txt", true))
		{
			String recordS="";
			// print("this"+this.transform.position);
			// print("last"+lastposition);
			// print("cut"+(this.transform.position.magnitude - lastposition.magnitude));
			
			recordS +="s1:"+ String.Format("{0,-20}", (this.transform.position.magnitude - lastposition.magnitude));
			recordS += "s2:"+ String.Format("{0,-20}", Math.Round(this.transform.position.x-lastposition.x,6));
			recordS +="a"+  String.Format("{0,-10}", a);
			recordS +="speed"+  String.Format("{0,-10}", speed);
			file.WriteLine(recordS);// 直接追加文件末尾，换行 
				
			
		}
		lastposition = this.transform.position;
		
		a = (speed - lastspeed) / 0.02;
//		print(String.Format("{0,-10}", a));
		
		
		lastspeed = speed;
		flag += 1;
		if (flag == 3)
		{
			//showSpeed();
			flag = 0;
		}
	
	}
	void showSpeed()
	{
		Debug.Log("速度"+speed.ToString());
		Debug.Log("质量"+rigidbody.mass);
		Debug.Log("加速度" + a.ToString());
	}
}
