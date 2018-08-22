using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_platform : MonoBehaviour {
	
	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Pressed primary button.");
			Vector3 p = transform.position;
			transform.position = new Vector3((p.x-3f), p.y, 0);
		}
		if (Input.GetMouseButtonDown (1)) {
			Debug.Log ("Pressed secondary button.");
			Vector3 p = transform.position;
			transform.position = new Vector3((p.x+3f), p.y, 0);

		}
	}
}
