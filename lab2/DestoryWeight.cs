using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryWeight : MonoBehaviour {
	private void OnTriggerEnter(Collider other)
	{
//		print("Tag");
		if (other.tag.Equals("Weight"))
		{
//			print("**************************************");
			Destroy(other.gameObject);
		}
	}
}
