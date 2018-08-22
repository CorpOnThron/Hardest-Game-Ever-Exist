using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camer_final_script : MonoBehaviour {

	public GameObject player;       //Public variable to store a reference to the player game object


	private Vector3 offset;         //Private variable to store the offset distance between the player and camera

	// Use this for initialization
	void Start () 
	{
		//Calculate and store the offset value by getting the distance between the player's position and camera's position.

	}

	// LateUpdate is called after Update each frame
	void LateUpdate () 
	{
		offset = player.transform.position;
		offset.z = -563f;
		offset.y = offset.y + 5f;
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
		transform.position = offset;
	}

}
