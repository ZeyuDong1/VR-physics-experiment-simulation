using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditMass : MonoBehaviour {

	public Text inputText;
	public GameObject target;
	public GameObject wrongOjb;
	public Text updateText;
	
	private void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(ChangeMass);
	}
	
	public void ChangeMass()
	{
		float mass=target.GetComponent<Rigidbody>().mass;
		bool isWrong = false;
		
		try
		{
			mass=float.Parse(inputText.text);
		}
		catch (Exception e)
		{
			isWrong = true;
			
		}

		if (isWrong)
		{
			wrongOjb.SetActive(true);
			inputText.text = "";
			
		}
		else
		{
			wrongOjb.SetActive(false);
			target.GetComponent<Rigidbody>().mass = mass;
			transform.parent.gameObject.SetActive(false);
			updateText.text = mass.ToString() + "KG";
			
			
		}
	}
}
