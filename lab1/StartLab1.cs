using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class StartLab1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Begin()
	{
		GameObject Dsnap1 = GameObject.FindWithTag("DownSnap");
		GameObject Usnap = GameObject.FindWithTag("UpSnap");
		print("begin");
		if ( Dsnap1!=null && Dsnap1.active  )
		{
			print("run1");
			print(Dsnap1.GetComponent<VRTK_SnapDropZone>().GetIsSnapped());
			if (Dsnap1.GetComponent<VRTK_SnapDropZone>().GetIsSnapped())
			{
				print("run2");
				GameObject cube = GameObject.FindWithTag("Cube");
				cube.GetComponent<Rigidbody>().isKinematic = false;
				//GameObject weight = GameObject.FindWithTag("Weight");
				//weight.GetComponent<Rigidbody>().isKinematic = false;
				cube.GetComponent<Rigidbody>().useGravity = true;
				//weight.GetComponent<Rigidbody>().useGravity = true;
			}
		}
		else if ( Usnap!=null && Usnap.active )
		{
			print("run3");
			if (Usnap.GetComponent<VRTK_SnapDropZone>().GetIsSnapped())
			{
				GameObject cube = GameObject.FindWithTag("Cube");
			//	GameObject weight = GameObject.FindWithTag("Weight");
				
				cube.GetComponent<Rigidbody>().isKinematic = false;
				
				// weight.GetComponent<Rigidbody>().isKinematic = false;
				// weight.GetComponent<Rigidbody>().useGravity = true;
				cube.GetComponent<Rigidbody>().useGravity = true;
			}
		}
		else
		{
			print("777");
		}
		
	}
}
