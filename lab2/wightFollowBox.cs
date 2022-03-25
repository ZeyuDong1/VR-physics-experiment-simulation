using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wightFollowBox : MonoBehaviour {
	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag.Equals("box") || other.gameObject.tag.Equals("dragWeight"))
		{
			GetComponent<Rigidbody>().useGravity = false;
			GetComponent<Rigidbody>().isKinematic = true;
			transform.parent = other.transform;
		}
	}
}
