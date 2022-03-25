using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bollSpeed : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Rigidbody>().velocity=new Vector3(1,0,0);
	}
}
