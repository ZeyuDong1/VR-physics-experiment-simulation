using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class changeFriction : MonoBehaviour {
	Slider slider;

	public GameObject target;
	public GameObject target2;

	// Use this for initialization
	void Start () {
		slider=gameObject.GetComponent<Slider>();
		slider.onValueChanged.AddListener(SliderChange);
	}
    
	void SliderChange(float t)
	{
		print(t);
		target.GetComponent<MeshCollider>().material.dynamicFriction = (float)Math.Round(t,1);
		target2.GetComponent<BoxCollider>().material.dynamicFriction = (float)Math.Round(t,1);
		print("1"+target2.GetComponent<BoxCollider>().material.dynamicFriction);
		GameObject.FindWithTag("ball").GetComponent<Rigidbody>().angularDrag=(float)Math.Round(t,1);

	}

}
