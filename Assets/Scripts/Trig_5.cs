using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig_5 : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		GameObject flag;
		flag = GameObject.Find ("Camera");

		if (other.gameObject.tag == "Player") {
			flag.gameObject.GetComponent<CameraScript> ().enabled = true;
			UnityEngine.Camera.main.orthographicSize = 8f;
		} 
	}
}
