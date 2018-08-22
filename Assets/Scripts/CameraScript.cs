using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public GameObject bob;
	public Vector3 offSet;

	void Start()
	{
		offSet = transform.position - bob.transform.position;

	}

	void LateUpdate()
	{

		Vector3 pos = bob.transform.position;
		Vector3 currPos = transform.position;
		pos.x += (offSet.x/3);
		transform.position = new Vector3(pos.x,currPos.y,currPos.z);
	}
}
