using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToBegin : MonoBehaviour {

	// Use this for initialization
	private void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(backTObegin);
	}

	void backTObegin()
	{
		SceneManager.LoadScene("beginScene");
	}
}
