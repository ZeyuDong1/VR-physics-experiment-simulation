using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calInput : MonoBehaviour {

	public Text inputText;

	private void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(Onclick);
	}
	
	void Onclick()
	{
		inputText.text += gameObject.name;
		
	}
}
