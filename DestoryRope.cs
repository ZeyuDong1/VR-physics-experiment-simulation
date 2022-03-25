using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryRope : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//print("run");
		
	}

	private void OnTriggerExit(Collider other)
	{
		//print(other.name);
		if (other.tag.Equals("Rope"))
		{
			Destroy(other.gameObject);
		}
	}
	
	private void OnTriggerEnter(Collider other)
	{
		//print(other.name);
		if (other.tag.Equals("Rope"))
		{
			Destroy(other.gameObject);
		}
	}



}
