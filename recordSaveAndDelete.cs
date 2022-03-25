using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recordSaveAndDelete : MonoBehaviour
{
	private List<Record> records;


	// Use this for initialization
	public void saveRecord()
	{
		records = GameObject.FindWithTag("recordText").GetComponent<getRecord>().getRecords();
		//将实验记录保存到文件中
		using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"record.txt", true))
		{
			String recordS="";
			recordS+=DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff");
			recordS += "\r";
			foreach (Record record in records)
			{
				recordS +="加速度:"+ String.Format("{0,-10}", Math.Round(record.Acceleration,2));
				recordS += "质量:"+ String.Format("{0,-10}", Math.Round(record.Mass,2));
				recordS += "重力加速度"+ String.Format("{0,-10}",Math.Round(record.g,2));
				recordS += "角度"+ String.Format("{0,-10}",Math.Round(record.Angle,2));
				recordS +="摩擦力"+  String.Format("{0,-10}", Math.Round(record.Friction,2));
				recordS +="摩擦系数"+  String.Format("{0,-10}", Math.Round(record.CoF,2));
				recordS += "\r";
				
				file.WriteLine(recordS);// 直接追加文件末尾，换行 
			}
		}
	}

	public void CleanRecord()
	{
		GameObject.FindWithTag("recordText").GetComponent<getRecord>().cleanRecord();
	}
}
