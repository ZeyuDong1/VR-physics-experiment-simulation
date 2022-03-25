using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVoiceOfWeightDropDown : MonoBehaviour
{
	private bool flag = true;
	private void OnCollisionEnter(Collision other)
	{
		if(flag)
		{
			flag = false;
		}
		else
		{
			GetComponent<AudioSource>().Play();

		}
	}
}
