using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Entry3 : MonoBehaviour {


	// Use this for initialization
	void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(OnClick);
	}

	void OnClick()
	{
		SceneManager.LoadScene("experiment3");
	}
}
