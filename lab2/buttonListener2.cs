using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class buttonListener2 : MonoBehaviour
{
	private VRTK_ControllerEvents vrtkControllerEvents;
	private bool flag;
	

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
		if (menu.activeSelf==false)
		{
//			print("run1");
			menu.SetActive(true);
			flag = false;

		}
		else
		{
			menu.SetActive(false);
			flag = true;
			
		}
		
		
	}

}
