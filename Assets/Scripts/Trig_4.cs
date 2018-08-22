using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig_4 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		GameObject flag;
		flag = GameObject.Find("Camera");
		GameObject shield = GameObject.Find("shield");

		if (other.gameObject.tag == "Player") {
			flag.gameObject.GetComponent<CameraScript>().enabled = false;
			flag.transform.position = new Vector3(145.335f, 1.97f, -563f);
			UnityEngine.Camera.main.orthographicSize = 10f;
			shield.GetComponent<move_platform> ().enabled = false;
		} 
	}
}
