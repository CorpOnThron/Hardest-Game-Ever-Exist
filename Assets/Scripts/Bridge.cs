using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour {
	

	public void ForceMove(){
		Debug.Log ("called");

		Vector3 p = transform.position;
		if (p.x < 14) {
			transform.position = new Vector3 ((p.x + 0.4f), p.y, 0.1f);
		} else if (p.x > 25) {
			transform.position = new Vector3 ((p.x - 0.21f), p.y, 0.1f);
		}
		}
}
