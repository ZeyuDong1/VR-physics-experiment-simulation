using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopEditPanel : MonoBehaviour {

	public GameObject input;
	public Text text;
	
	private void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(inputField);
	}
	
	public void inputField()
	{
		text.text = "";
		
		input.SetActive(true);
	}
	
	
}
