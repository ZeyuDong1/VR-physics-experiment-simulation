using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class CarRecord
{
	private List<double> recordlist;
	private double massesOfcar;
	private double massesOfWeight;

	public CarRecord(List<double> r,double mOc,double mOw)
	{
		recordlist = new List<double>(r);
		massesOfcar = mOc;
		massesOfWeight = mOw;
		
		
	}
	public double MassesOfcar
	{
		get { return massesOfcar; }
	}

	public double MassesOfWeight
	{
		get { return massesOfWeight; }
	}

	public List<double> Recordlist
	{
		get { return recordlist; }
	}
	

}



public class getCarMove : MonoBehaviour {
	private GameObject car;
	private List<double> Slist;
	Text text;
	private double massOfcar;
	private double massOfWeight;
	private List<CarRecord> carRecords;

	//是否添加干扰
	private bool isAddInter=false;
	
	private void Start()
	{
		car = GameObject.FindWithTag("car");
		text = GetComponent<Text>();
		carRecords=new List<CarRecord>();
	}
	
	
	public void onInter()
	{
		isAddInter = true;
	}
	
	public void offInter()
	{
		isAddInter = false;
	}
	public void updateRecord()
	{
		Slist = car.GetComponent<carMove>().getSlist();
		massOfcar = car.GetComponent<carMove>().MassOfCar;
		massOfWeight = car.GetComponent<carMove>().MassOfWeight;
		
		text.text = "";

		for (int i = 0; i < Slist.Count; i++)
		{
			if (isAddInter)
			{
				
				byte[] buffer = Guid.NewGuid().ToByteArray();//生成字节数组
				int iRoot = BitConverter.ToInt32(buffer, 0);//利用BitConvert方法把字节数组转换为整数
				Random rdmNum = new Random(iRoot);//以这个生成的整数为种子
				double randomInter = rdmNum.Next(-10, 10)/10000f;
				print(randomInter);
				print(Slist[i]);
				
				Slist[i] += randomInter;
				print(Slist[i]);
				print("*****************************");

			}
			if (i == 0)
			{				
				text.text += String.Format("{0,-10}", Math.Round(Slist[i] * 100f, 2));

			}
			else
			{
				text.text += String.Format("{0,-10}", Math.Round((Slist[i]-Slist[i-1]) * 100f, 2));
			}

			if (i % 3 == 0)
			{
				text.text += "\r";
				
			}
		}
		//放到类中，方便保存
		CarRecord newRecord=new CarRecord(Slist,massOfcar,massOfWeight);
		carRecords.Add(newRecord);
		if (isAddInter)
		{
			text.text += "\r\n" ;
			text.text += "\r\n" + "由于存在随机的误差，加速度的计算没有意义";
			text.text += "\r\n" + "请保存数据，实验结束后根据数据画坐标图";
			text.text += "\r\n" + "并根据课本中的要求使用图像法测试查看数据";

		}
		else
		{
			text.text += "\r\n" + "加速度为(m/s):" + Math.Round(car.GetComponent<carMove>().getAce(),1);
			text.text += "\r\n" + "小车质量为(KG):" + massOfcar;
			text.text += "\r\n" + "拉力为(N):" + Math.Round(massOfWeight*Math.Abs(Physics.gravity.y),1);
		}
		


		
		car.GetComponent<carMove>().cleanSlist();
	}
	
	
	public  List<CarRecord> getcarrecord()
	{
		return carRecords;
	}
	
		
	
}
