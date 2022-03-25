using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteShowKG : MonoBehaviour {
	public GameObject target;
	
	private void OnTriggerExit(Collider other)
	{
		if (other.tag.Equals("CubeWaite"))
		{
			Destroy(target);		
		}
	}
}
