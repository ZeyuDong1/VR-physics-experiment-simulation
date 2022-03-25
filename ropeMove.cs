using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ropeMove : MonoBehaviour
{
	private Transform target;

	private Vector3 startPostion;
	
	// Use this for initialization
	void Start ()
	{
		target =GameObject.FindWithTag("car").transform;
		startPostion = this.transform.position;
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		this.transform.position = startPostion +GameObject.FindWithTag("car").GetComponent<carMove>().Move ;
		
	}
}
