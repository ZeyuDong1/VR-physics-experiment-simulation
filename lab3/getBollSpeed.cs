using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getBollSpeed : MonoBehaviour
{

	private double speed;
	private double a;
	private double lastspeed;


	// Use this for initialization
	void Start()
	{

	}

	public double getSpeed()
	{
		return speed;
	}

	// Update is called once per frame
	void Update()
	{

		{

			speed = GetComponent<Rigidbody>().velocity.magnitude;
			a = (speed - lastspeed) / 0.02;
			lastspeed = speed;

			//showSpeed();
		}

		

	}
	void showSpeed()
	{
		// print(speed);
		Debug.Log("速度" + speed.ToString());
		Debug.Log("质量" + GetComponent<Rigidbody>().mass);
		Debug.Log("加速度" + a.ToString());
	}
}
