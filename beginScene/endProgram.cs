using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endProgram : MonoBehaviour {

	public void onClick()
	{
		print("qut");
		#if UNITY_EDITOR
		         UnityEditor.EditorApplication.isPlaying = false;
		 #else
         Application.Quit();
		#endif
	}
}
