using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showBollSpeed : MonoBehaviour {

	private double speed;

	private Text text;
	
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (GameObject.FindWithTag("Ideal") == null && GameObject.FindWithTag("ball")!=null)
		{
			text.text = "实时速度为:";
			speed = GameObject.FindWithTag("ball").GetComponent<getBollSpeed>().getSpeed();
			text.text += Math.Round(speed, 2);
		}
		
		
	}
}
