using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig_3 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		GameObject flag;
		flag = GameObject.Find("Camera");
		GameObject[] meteor = GameObject.FindGameObjectsWithTag("meteor");
		GameObject shield = GameObject.Find("shield");



		if (other.gameObject.tag == "Player") {
			flag.gameObject.GetComponent<CameraScript>().enabled = false;
			flag.transform.position = new Vector3(106.9f, 7f, -563f);
			UnityEngine.Camera.main.orthographicSize = 8f;
			foreach( GameObject obj in meteor)
			{
			obj.GetComponent<Rigidbody2D> ().gravityScale = 1;
			}
			shield.GetComponent<move_platform> ().enabled = true;



		} 
	}
}