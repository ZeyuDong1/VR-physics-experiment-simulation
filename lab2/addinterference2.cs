using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addinterference2 : MonoBehaviour
{
	public GameObject target;
	public void OnClick(bool isOn)
	{
		if (isOn)
		{
			print("run1");
			//target.SetActive(true);
			target.GetComponent<getCarMove>().onInter();
			print("onThis");
			
		}
		else
		{
			print("run2");
			target.GetComponent<getCarMove>().offInter();

			//target.SetActive(false);
		}
	}
}
