using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changG : MonoBehaviour
{

	public void OnClick(bool isOn)
	{
		if (isOn)
		{
			Physics.gravity= new Vector3(0,-10,0);
			print(Physics.gravity);
		}
		else
		{
			Physics.gravity= new Vector3(0,-9.8f,0);
			print(Physics.gravity);		}
	}
}
