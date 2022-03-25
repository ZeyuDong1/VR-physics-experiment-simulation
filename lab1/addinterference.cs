using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addinterference : MonoBehaviour
{
	public GameObject target;
	public void OnClick(bool isOn)
	{
		if (isOn)
		{
			print("run1");
			//target.SetActive(true);
			target.GetComponent<getRecord>().onInter();
			
		}
		else
		{
			print("run2");
			target.GetComponent<getRecord>().offInter();

			//target.SetActive(false);
		}
	}
}
