using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showWeightMass : MonoBehaviour
{

	public Text text;

	private void LateUpdate()
	{
		if (GameObject.FindWithTag("Weight") != null)
		{
			text.text = GameObject.FindWithTag("Weight").GetComponent<Rigidbody>().mass.ToString()+"KG";

		}
		
	}
}
