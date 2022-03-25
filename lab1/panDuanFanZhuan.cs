using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panDuanFanZhuan : MonoBehaviour {
	//物体拖进区域的角度，决定激活哪一个Snap
	public GameObject zhengfang;

	public GameObject daofang;

	public GameObject showData;

	public GameObject showTip;
	private bool flag = true;
	
	// private void OnTriggerExit(Collider other)
	// {
	// 	if (flag==true)
	// 	{
	// 		flag = false;
	//
	// 	}
	// 	else if(flag==false)
	// 	{
	// 		flag = true;
	// 		
	// 	}
	// 	print("exit"+flag);
	// 	
	// }

	private void OnTriggerEnter(Collider other)
	{
		
		if (other.tag.Equals("Cube") || other.tag.Equals("CubeWaite")|| other.tag.Equals("CubeUnusing"))
		{
			//如果有其他物体的tag为Cube，则修改其tag
			if(GameObject.FindWithTag("Cube"))
			{
				GameObject.FindWithTag("Cube").tag = "CubeUnusing";
			}
			other.tag = "Cube";

			print("enter" + flag);
			showTip.SetActive(true);
			if (flag)
			{
					zhengfang.SetActive(true);
					daofang.SetActive(false);
					flag = false;
			}
			else
			{
					zhengfang.SetActive(false);
					daofang.SetActive(true);
					flag = true;
					
			}
			//跟随显示数据
			showData.SetActive(true);
			
		}
		
       
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag.Equals("Cube") || other.tag.Equals("CubeWaite")|| other.tag.Equals("CubeUnusing"))
		{
			showTip.SetActive(false);
			
		}

			
	}
}
