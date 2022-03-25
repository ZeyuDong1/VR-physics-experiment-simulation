using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeMaterial : MonoBehaviour
{

	public Material other;
	public MeshRenderer meshRender;  //声明MeshRenderer组件
	public PhysicMaterial otherP;
	public MeshCollider meshCollider;
	void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(OnClick);
	}

	void OnClick()
	{
		meshRender.material = other;
		meshCollider.material = otherP;
	}
}
