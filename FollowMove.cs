using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMove : MonoBehaviour {

	Transform lastTransform;

	Vector3 move;
	
	// Use this for initialization
	void Start () {
		lastTransform = this.transform;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		move = this.transform.position - lastTransform.position;

	}
}
