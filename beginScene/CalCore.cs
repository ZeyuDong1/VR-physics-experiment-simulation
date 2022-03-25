using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using ConsoleApplication1;

public class CalCore : MonoBehaviour {
	public Text input;
	string cal = "";
	
	CalcOperation calcOperation=new CalcOperation();
	private void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(getResult);
	}
	
	public void getResult()
	{
		bool isWrong=false;
		cal = input.text;
		
		string r="";
		if (input.text.Equals(""))
		{
			isWrong = true;
			
		}
		else
		{
			isWrong = CalCos();
	
			try
			{
				DataTable dt = new DataTable();
				r = dt.Compute(cal, "false").ToString();
				
			}
			catch (Exception e)
			{
				isWrong = true;
			}

			
		}
		if (isWrong)
		{
			input.text = "ERROR";
		}
		else
		{
			input.text = r;
			
		}
	}
	
	
	
	private bool CalCos()
	{
		bool isWrong = false;
		String getCos = "";
		while (cal.IndexOf("cos") > 0)
		{
			//Stack sanjiaohanshu =new Stack();
			int head = cal.IndexOf("cos");
			if (!(cal[head+3]=='('))
			{
				isWrong = true;
				break;
			}
			else
			{
				for (int i = head+4; i < cal.Length; i++)
				{
					//sanjiaohanshu.Push(s[i]);
					getCos += cal[i];
					if ((cal[i]==')'))
					{
						break;
					}
				}
				//getCos = sanjiaohanshu.ToString();
				if (getCos.IndexOf(")")<0)
				{
					isWrong = true;
					break;
				}
			}

			getCos = getCos.Substring(0, getCos.Length - 1);
			double result = Math.Round(Math.Sin(Math.PI*Double.Parse(getCos)/180),5);
			cal=cal.Replace("cos("+getCos+")", result.ToString());
		}

		return isWrong;
	}
}
