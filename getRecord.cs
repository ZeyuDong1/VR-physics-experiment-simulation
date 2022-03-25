using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
using Random = System.Random;

//将记录设定为类
public class Record
{
	public double Acceleration;//加速度
	public double Friction;//摩擦力
	public double CoF;//摩擦系数
	public double Mass;//质量
	public double Angle;//角度
	public double g;//重力加速度


	public Record(double ac,double q,double ang)
	{
		Angle = ang;
		Acceleration = ac;
		Mass = q;
		g=System.Math.Abs(Physics.gravity.y);//获取重力系数的绝对值
		getFriction();
	}

	private void getFriction()
	{
		double Fhe = Acceleration * Mass;//物块在斜坡方向坐标轴的合力
		double f = Mass * g * Math.Sin(Math.PI / 6);//获取斜坡方向的重力分力
		Friction = Math.Round(f,4) - Fhe;
//		Debug.Log(Angle);
//		Debug.Log(f);
		CoF=Friction/(Mass * g * Math.Cos(Math.PI / 6));
	}
}

 public class getRecord : MonoBehaviour
 {
	 private bool isaddinterference=false;
	 private List<Record> records;
	public Text recordText;
	// public Text DetailData;
	public double Angle;
	private void Awake()
	{
		records = new List<Record>();
	}

	public void onInter()
	{
		isaddinterference = true;
	}
	
	public void offInter()
	{
		isaddinterference = false;
	}
	
	public void cleanRecord()
	{
		records.Clear();
		recordText.text = "";
	}

	public List<Record> getRecords()
	{
		return records;
	}
	//更新记录
	void updateText(double ac)
	{
//		Debug.Log("running updatetext");
		
		double mass;
		mass = GameObject.FindWithTag("Cube").GetComponent<Rigidbody>().mass;
		//判断是否有砝码
		// if(GameObject.FindWithTag("weightTrigger").GetComponent<weightTrigger>().getHasWeight())
		// {
		// 	mass += GameObject.FindWithTag("Weight").GetComponent<Rigidbody>().mass;
		// }
		//是否添加干扰
		if(isaddinterference)
		{
			Random random = new Random();
			double randomAc = random.Next(-10, 10) / 100f;
			print(randomAc);
			records.Add(new Record(ac+(randomAc),mass,Angle));
		}
		else
		{
			records.Add(new Record(ac,mass,Angle));

		}
		recordText.text = "";
		foreach (var record in records)
		{
			// recordText.text += String.Format("{0,-20}",String.Format("{0:#.#}", record.Acceleration));
			// recordText.text += String.Format("{0,-20}",String.Format("{0:#.#}", record.Acceleration));

			// recordText.text += record.CoF.ToString("####.#,-10");
			recordText.text += String.Format("{0,-20}",Math.Round(record.Acceleration,3));
			recordText.text += String.Format("{0,-20}",Math.Round(record.Friction,3));
			recordText.text += String.Format("{0,-20}",Math.Round(record.CoF,3));
			recordText.text += "\r";
			// //显示详细数据
			// DetailData.text += String.Format("{0,-10}", Math.Round(record.Acceleration,2));
			// DetailData.text += String.Format("{0,-10}", Math.Round(record.Mass,2));
			// DetailData.text += String.Format("{0,-10}",Math.Round(record.g,2));
			// DetailData.text += String.Format("{0,-10}",Math.Round(record.Angle,2));
			// DetailData.text += String.Format("{0,-10}", Math.Round(record.Friction,2));
			// DetailData.text += String.Format("{0,-10}", Math.Round(record.CoF,2));
			
		}
		GameObject.FindWithTag("DetailData").gameObject.GetComponent<getDetailData>().updateRecord();

		
		// //将实验记录保存到文件中
		// using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"record.txt", true))
		// {
		// 	String recordS="";
		// 	foreach (Record record in records)
		// 	{
		// 		recordS +="加速度:"+ String.Format("{0,-10}", Math.Round(record.Acceleration,2));
		// 		recordS += "质量:"+ String.Format("{0,-10}", Math.Round(record.Mass,2));
		// 		recordS += "重力加速度"+ String.Format("{0,-10}",Math.Round(record.g,2));
		// 		recordS += "角度"+ String.Format("{0,-10}",Math.Round(record.Angle,2));
		// 		recordS +="摩擦力"+  String.Format("{0,-10}", Math.Round(record.Friction,2));
		// 		recordS +="摩擦系数"+  String.Format("{0,-10}", Math.Round(record.CoF,2));
		// 		file.WriteLine(recordS);// 直接追加文件末尾，换行 
		// 		
		// 	}
		// }

	}
}
