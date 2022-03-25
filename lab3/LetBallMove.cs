using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetBallMove : MonoBehaviour {

	public GameObject ballObj;
	
	public void ballmove()
	{
		ballObj.GetComponent<Rigidbody>().isKinematic = false;
		ballObj.GetComponent<Rigidbody>().useGravity = true;
	}
}
