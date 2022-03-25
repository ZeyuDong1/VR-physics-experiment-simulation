using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideRope : MonoBehaviour {
	private void Start()
	{
		
		print("run");
	}

	private void OnTriggerStay(Collider other)
	{
		//print(other.name);
		if(other.tag.Equals("Rope"))
		{
//			print("run");
			other.GetComponent<MeshRenderer>().enabled = false;
			
		}
		
	}

	private void OnTriggerExit(Collider other)
	{
//		print(other.name);
		other.GetComponent<MeshRenderer>().enabled = true;
	}
}
