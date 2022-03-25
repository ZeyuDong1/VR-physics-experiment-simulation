using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour {

	List<List<double>> records;
	public GameObject RecordInTHisOBj;
	List<CarRecord> carRecord;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	public void saveRecord()
	{
		carRecord = RecordInTHisOBj.GetComponent<getCarMove>().getcarrecord();
		//将实验记录保存到文件中
using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"record2.txt", true))
{
	String recordS="";
	recordS+=DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff");
	recordS+= "\r";
	foreach (var VARIABLE in carRecord)
	{
		recordS += "每0.02S的位移间隔（单位cm）";
		recordS+= "\r";
		for (int i = 0; i < VARIABLE.Recordlist.Count; i++)
		{
			if (i == 0)
			{				
				recordS+= String.Format("{0,-10}", Math.Round(VARIABLE.Recordlist[i] * 100f, 2));

			}
			else
			{
				recordS+= String.Format("{0,-10}", Math.Round((VARIABLE.Recordlist[i]-VARIABLE.Recordlist[i-1]) * 100f, 2));
			}

			if (i % 5 == 0)
			{
				recordS+= "\r";
		
			}
		}
		recordS += "\r\n" + "加速度为(m/s):" +Math.Round(GameObject.FindWithTag("car").GetComponent<carMove>().getAce(),1);
		recordS += "\r\n" + "小车质量为(KG):" + Math.Round(VARIABLE.MassesOfcar,0);
		recordS+= "\r\n" + "拉力为(N):" + Math.Round(VARIABLE.MassesOfWeight*Math.Abs(Physics.gravity.y),0);
		
		file.WriteLine(recordS);// 直接追加文件末尾，换行 
	}
	
}
	}

}
