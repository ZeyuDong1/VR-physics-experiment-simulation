using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weightTrigger : MonoBehaviour
{
	private bool WeightIn=false;//砝码是否在触发器中
	private bool hasWeight = false;//实验时是否有砝码

	private void Awake()
	{
		WeightIn=false;
		hasWeight = false;
	}
	//获取砝码是否放置

	//重置砝码
	public void resetHasWeight()
	{
		hasWeight = false;
		WeightIn = false;
	}
	//当砝码位于预制体中，开始实验时调用该函数，用于记录实验是否有砝码参与
	public void StartLab()
	{
		if (WeightIn)
		{
			hasWeight = true;
		}

	}

	public bool getHasWeight()
	{
		return hasWeight;
	}
	
	private void OnTriggerStay(Collider other)
	{
		//Debug.Log(other.gameObject.tag);
		if (other.gameObject.tag.Equals("Weight"))
		{
			//Debug.Log("进入");

			WeightIn = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag.Equals("Weight"))
		{
			//Debug.Log("离开");

			WeightIn = false;
		}
	}
}
