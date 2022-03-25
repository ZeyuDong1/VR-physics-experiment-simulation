using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createRope : MonoBehaviour {
	//当第一个节点到达第二节点的位置是，在原位置上创建新的节点
	private bool isCreate=true;
	private Vector3 initTransform;
	public Transform nextJoint;
	private Vector3 initNext;
	
	
	
	private void Start()
	{
		isCreate = true;
		
		initTransform = transform.position;
		initNext = nextJoint.position;
		
		
	}
	private void FixedUpdate()
	{
		print(transform.position.y);
		print(initNext.y);
		print("*****************");
		if (transform.position.y < initNext.y && isCreate)
		{
			print("create");
			GameObject newJoint = Instantiate(gameObject);
			newJoint.transform.position = initTransform;
			
			//设置为子物体保证移动
			newJoint.transform.parent = GameObject.FindWithTag("ropes").transform;
			isCreate = false;
			
		}
	}
	// private void OnTriggerExit(Collider other)
	// {
	// 	print(other.tag);
	// 	if (other.tag.Equals("Rope") && isCreate)
	// 	{
	// 		GameObject newJoint = Instantiate(fristRopeJoint, initTransform);
	// 		//设置为子物体保证移动
	// 		newJoint.transform.parent = GameObject.FindWithTag("DownRope").transform;
	// 	}
	// }
}
