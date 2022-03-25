using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showDetailData : MonoBehaviour {
	public GameObject target;
	
	public void OnClick(bool isOn)
	{
		if (isOn)
		{
			print("run1");
			target.SetActive(true);
		}
		else
		{
			print("run2");
			target.SetActive(false);
		}
	}
}
