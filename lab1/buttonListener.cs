using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class buttonListener : MonoBehaviour
{
	private VRTK_ControllerEvents vrtkControllerEvents;
	private bool flag;
	
	public GameObject lab1;

	public GameObject menu;
	
	// Use this for initialization
	void Start () {
		vrtkControllerEvents=GetComponent<VRTK_ControllerEvents>();
		vrtkControllerEvents.ButtonOnePressed += B1Pressed;
		flag = true;

		vrtkControllerEvents.TouchpadAxisChanged += B1Pressed;


	}
	
	private void B1Pressed(object sender,ControllerInteractionEventArgs e)
	{
		if (flag)
		{
//			print("run1");
			lab1.SetActive(false);
			menu.SetActive(true);
			flag = false;

		}
		else
		{
			lab1.SetActive(true);
			menu.SetActive(false);
			flag = true;
			
		}
		
		
	}

}
