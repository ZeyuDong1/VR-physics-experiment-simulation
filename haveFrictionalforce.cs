using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class haveFrictionalforce : MonoBehaviour
{

	public Rigidbody targetRigidbody;
	public TextMesh tip;
	private Vector3 position;
	void Start ()
	{
		position = targetRigidbody.position;
		tip.text = "无摩擦力";
	}
	public void haveFriction()
	{

		if (targetRigidbody.drag == 0)
		{
			targetRigidbody.drag = 0.1f;
			tip.text = "有摩擦力";
		}
		else
		{
			targetRigidbody.drag =0;
			tip.text = "无摩擦力";
		}

		targetRigidbody.position = position;

	}
	
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
