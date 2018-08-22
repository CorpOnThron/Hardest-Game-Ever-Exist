using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour {


	public void geUp(){
		
		transform.position = new Vector3(42.72f, 0.65f, 0.0f);
		//transform.Find ("free-spikes-and-blades_3 (1)").GetComponent.transform.position = new Vector3 (0.005f, -5.17f, 0f);
		//transform.Find ("free-spikes-and-blades_3 (2)").GetComponent.transform.position = new Vector3 (0.005f, -5.17f, 0f);
	}

	public void getDown(){

		transform.position = new Vector3(42.72f, -2.17f, 0.0f);
		//transform.Find ("free-spikes-and-blades_3 (1)").GetComponent.transform.position = new Vector3 (0.005f, -5.17f, 0f);
		//transform.Find ("free-spikes-and-blades_3 (2)").GetComponent.transform.position = new Vector3 (0.005f, -5.17f, 0f);
	}
}
