using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig1 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		GameObject flag;
		flag = GameObject.Find("Camera");

		if (other.gameObject.tag == "Player") {
			flag.gameObject.GetComponent<CameraScript>().enabled = false;
			flag.transform.position = new Vector3(53.88f, 3.15033f, -563f);
			UnityEngine.Camera.main.orthographicSize = 10f;
		} 
	}
}

