using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordRopeInitDestoryPosition : MonoBehaviour
{

	public Transform lastJointOfRope;

	private Vector3 position;
	// Use this for initialization
	void Start ()
	{
		position = lastJointOfRope.position;
	}
	public Vector3 getPosition()
	{
		print(position);
		return position;
	}
}
