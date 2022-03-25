using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ts : MonoBehaviour {
	bool flag = true;
	Vector3 speedRecord;
	
	private void OnTriggerEnter(Collider other)
	{
//		print(flag);

		if (flag)
		{
			flag = false;
			speedRecord = other.GetComponent<Rigidbody>().velocity;
		}
		if (other.GetComponent<Rigidbody>().velocity.x<0)
		{
			other.GetComponent<Rigidbody>().velocity = new Vector3(speedRecord.x, 0f, 0.0f)*1.1f;
		}
		else
		{
			other.GetComponent<Rigidbody>().velocity = new Vector3(-speedRecord.x, 0f, 0.0f)*1.1f;
			
		}
	}
}
