using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetLab : MonoBehaviour {

	public GameObject car;
	public GameObject weights;
	public GameObject getNewRopeFormBeginButton;
	public GameObject tip1;
	public GameObject tip2;
	//public GameObject rope;

	private Vector3 carP;
	private Vector3 weightP;
	private List<GameObject> usingWeight;

	

	private void Start()
	{
		carP = car.transform.position;
		weightP = weights.transform.position;
		usingWeight = new List<GameObject>();

	}

	// Use this for initialization
	public void resetThisLab()
	{
		car.GetComponent<carMove>().restart();
		if (GameObject.FindGameObjectsWithTag("carWeight").Length > 0)
		{
			foreach (var w in GameObject.FindGameObjectsWithTag("carWeight"))
			{
				usingWeight.Add(w);
			}
		}
		
		if (GameObject.FindGameObjectsWithTag("dragWeight").Length > 0)
		{
			foreach (var w in GameObject.FindGameObjectsWithTag("dragWeight"))
			{
				usingWeight.Add(w);
			}
		}

		if (usingWeight.Count > 0)
		{
			foreach (var VARIABLE in usingWeight)
			{
				Destroy(VARIABLE.gameObject);
			}
		}
		//如果小车运动过，则删除旧的绳子
		if(GameObject.FindWithTag("car").GetComponent<carMove>().getIsBegin())
		{
			//销毁旧的绳子,激活新的绳子之后修改其Tag
			Destroy(GameObject.FindWithTag("oldRope"));
			GameObject newRope=getNewRopeFormBeginButton.GetComponent<begincarlab>().getNewRope();
			newRope.SetActive(true);
			newRope.tag = "oldRope";
			
		}

		//隐藏tips
		tip1.SetActive(false);
		tip2.SetActive(false);
		//将其他物体回归原位
		car.transform.position = carP;
		weights.transform.position = weightP;
		
	}
}
