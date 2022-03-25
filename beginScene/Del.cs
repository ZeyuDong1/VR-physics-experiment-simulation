using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Del : MonoBehaviour {
	public Text inputText;

	private void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(Onclick);
	}
	
	void Onclick()
	{
		inputText.text = inputText.text.Substring(0, inputText.text.Length - 1);
		
		
	}
}
