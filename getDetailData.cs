using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getDetailData : MonoBehaviour
{
	public Text DetailData ;
	private List<Record> records;

	private void Awake()
	{
	}

	public void updateRecord()
	{
		records = GameObject.FindWithTag("recordText").GetComponent<getRecord>().getRecords();
		DetailData.text = "";
		foreach (var record in records)
		{
			// DetailData.text += String.Format("{0,-23}", Math.Round(record.Acceleration,2));
			// DetailData.text += String.Format("{0,-16}", Math.Round(record.Mass,2));
			// DetailData.text += String.Format("{0,-32}",Math.Round(record.g,2));
			// DetailData.text += String.Format("{0,-12}",Math.Round(record.Angle,2));
			// DetailData.text += String.Format("{0,-18}", Math.Round(record.Friction,2));
			// DetailData.text += String.Format("{0,-10}", Math.Round(record.CoF,2));
			DetailData.text += String.Format("{0,-23}", Math.Round(record.Acceleration,3));
			DetailData.text += String.Format("{0,-16}", Math.Round(record.Mass,3));
			DetailData.text += String.Format("{0,-32}",Math.Round(record.g,3));
			DetailData.text += String.Format("{0,-12}",Math.Round(record.Angle,3));
			DetailData.text += String.Format("{0,-18}", Math.Round(record.Friction,3));
			DetailData.text += String.Format("{0,-10}", Math.Round(record.CoF,3));
			DetailData.text += "\r\n";
		}
		
	}
}
