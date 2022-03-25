using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMass : MonoBehaviour {

	public GameObject target;
	
	private void FixedUpdate()
	{			GetComponent<Text>().text = target.GetComponent<Rigidbody>().mass.ToString()+"KG";

//		print("run");
		if (GameObject.FindWithTag("Weight") != null)
		{
			target = GameObject.FindWithTag("Weight");
			GetComponent<Text>().text = target.GetComponent<Rigidbody>().mass.ToString()+"KG";
		}
	}
}
