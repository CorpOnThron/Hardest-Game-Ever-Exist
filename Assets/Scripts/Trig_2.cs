using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig_2 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		GameObject flag;
		flag = GameObject.Find("Camera");
		GameObject blade = GameObject.Find("free-spikes-and-blades_4");;

		if (other.gameObject.tag == "Player") {
			flag.gameObject.GetComponent<CameraScript>().enabled = false;
			flag.transform.position = new Vector3(76.99f, 1.97f, -563f);
			UnityEngine.Camera.main.orthographicSize = 8f;
			blade.GetComponent<blade> ().speed.x = -0.5f;
		} 
	}
}
