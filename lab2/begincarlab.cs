using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class begincarlab : MonoBehaviour {
	public Text tip;
	public GameObject target;
	private GameObject newRope;
	
	public void letCarMove()
	{
		if (GameObject.FindGameObjectsWithTag("dragWeight").Length>0)
		{
			print(GameObject.FindGameObjectsWithTag("dragWeight").Length);
			//克隆一个绳子，用于下次实验
			GameObject rope = GameObject.FindWithTag("oldRope");
			newRope = Instantiate(rope) as GameObject;
			newRope.transform.parent = GameObject.FindWithTag("car").transform;
			newRope.transform.position = rope.transform.position;
			newRope.transform.localScale = rope.transform.localScale;
		
			newRope.SetActive(false);
		
			
			target.GetComponent<carMove>().beginLab();
		}
		else
		{
			tip.text = "请在桌子右边盒子里放入砝码后再点击开始试验";
			
		}
		
	}
	
	public GameObject getNewRope()
	{
		return newRope;
	}
}
