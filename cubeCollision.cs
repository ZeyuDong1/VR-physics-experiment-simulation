using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Vuforia;

public class cubeCollision : MonoBehaviour
{
	private bool isStop = false;
	private Transform stopTransform;
	private Collision otherCollision;
	public AudioSource axe;
	public AudioSource wood;
	private void Update()
	{
		// if (isStop)
		// {
		// 	otherCollision.gameObject.GetComponent<Rigidbody>().position = stopTransform.position;
		// 	otherCollision.gameObject.GetComponent<Rigidbody>().rotation = stopTransform.rotation;
		// 	Debug.Log(stopTransform.position);
		// 	Debug.Log(stopTransform.rotation);
		//
		// }
	}

	private void OnCollisionEnter(Collision other)
	{
	//	Debug.Log(other.gameObject.tag);
		//木块到达底部
		if (other.gameObject.tag.Equals("Cube") )
		{
		
			
			// other.gameObject.GetComponent<Rigidbody>().useGravity = false;
			// other.gameObject.GetComponent<Rigidbody>().velocity =Vector3.zero;
			// other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			// other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
			// other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
			
			//GameObject.FindWithTag("Weight").gameObject.AddComponent<Rigidbody>();
			//落地时播放对应音效
			if(this.GetComponent<AudioSource>().clip.name=="木头落地")
			{
				this.GetComponent<AudioSource>().Play();
//				Debug.Log("play");
				
			}
			//发生碰撞时，发送加速度到文本更新信息函数
			GameObject.FindWithTag("recordText").SendMessage("updateText", getAc());
			GameObject.FindWithTag("Cube").GetComponent<GetSpeed>().resetA();
			//碰撞后,记录完成之后修改Tag
			other.gameObject.tag = "CubeUnusing";
		}
		//碰撞时播放对应音效
		
		if (other.gameObject.name.Equals("metalCube"))
		{
			//Debug.Log("222");
			
			axe.Play();
		}
		if (other.gameObject.name.Equals("wood"))
		{
			//Debug.Log("222");
    			
			wood.Play();
		}
		
		
	}
	//从加速度数据中获取物体稳定的加速度
	private double getAc()
	{
		List<double> ac= GameObject.FindWithTag("Cube").GetComponent<GetSpeed>().getAccelerate();
		double a=0f;
		for (int i = 2; i < ac.Count-2; i++)
		{
			if (Math.Abs(ac[i] - ac[i - 2]) < 0.1&&Math.Abs(ac[i] - ac[i + 2]) < 0.1)
			{
				a = ac[i];
			}
		}

		//Debug.Log("Ace"+Math.Round(a, 1, MidpointRounding.AwayFromZero)); 
		return Math.Round(a,1,MidpointRounding.AwayFromZero);
	}
}
