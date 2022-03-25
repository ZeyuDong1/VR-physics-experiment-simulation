using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDetailData : MonoBehaviour {

	public void onClick()
	{
		gameObject.transform.parent.gameObject.SetActive(false);
		
	}
}
