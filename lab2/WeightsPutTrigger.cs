using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightsPutTrigger : MonoBehaviour {

	public GameObject tip;

	private void OnTriggerStay(Collider other)
	{
		if (other.tag.Equals("Weight"))
		{
			tip.SetActive(true);

		}
	
	}

	private void OnTriggerExit(Collider other)
	{
//		print(other.tag);
		if (other.tag.Equals("Weight"))
		{
			tip.SetActive(false);
		}	
	}
}
