using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopCar : MonoBehaviour {

	public GameObject Stext;
	public AudioSource woodCollision;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
//		print(other.tag);
		if (other.tag.Equals("car"))
		{
			other.GetComponent<carMove>().enabled = false;
			// other.GetComponent<Rigidbody>().velocity=Vector3.zero;
			// other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			Stext.GetComponent<getCarMove>().updateRecord();
			woodCollision.Play();
		}
	}
}
