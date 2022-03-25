using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForWeightPutInCar : MonoBehaviour {
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag.Equals("Weight"))
		{
			print("weightPutIncar");
			other.tag = "carWeight";
			other.transform.parent = GameObject.FindWithTag("car").transform;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag.Equals("carWeight"))
		{
			print("weightPutIncarOut");
			other.tag = "Weight";
		}	}
}
