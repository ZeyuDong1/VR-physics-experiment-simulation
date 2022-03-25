using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showIdealLab : MonoBehaviour {
	public GameObject ideal;
	public GameObject mainlab;
	Toggle toggle;

	private void Start()
	{
		toggle = GetComponent<Toggle>();
		toggle.onValueChanged.AddListener(click);
	}


	public void click(bool isOn)
	{
		print(isOn);
		if (isOn)
		{
			print("run1");
			ideal.SetActive(true);
			mainlab.SetActive(false);
			
		}
		else
		{
			print("run2");
			ideal.SetActive(false);
			mainlab.SetActive(true);
		}
	}
}
