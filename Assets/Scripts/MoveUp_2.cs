using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp_2 : MonoBehaviour {


	public void geUp2(){

		transform.position = new Vector3(46.57f, 0.65f, 0.0f);
		//transform.Find ("free-spikes-and-blades_3 (1)").GetComponent.transform.position = new Vector3 (0.005f, -5.17f, 0f);
		//transform.Find ("free-spikes-and-blades_3 (2)").GetComponent.transform.position = new Vector3 (0.005f, -5.17f, 0f);
	}

	public void getDown2(){

		transform.position = new Vector3(46.57f, -2.17f, 0.0f);
		//transform.Find ("free-spikes-and-blades_3 (1)").GetComponent.transform.position = new Vector3 (0.005f, -5.17f, 0f);
		//transform.Find ("free-spikes-and-blades_3 (2)").GetComponent.transform.position = new Vector3 (0.005f, -5.17f, 0f);
	}
}