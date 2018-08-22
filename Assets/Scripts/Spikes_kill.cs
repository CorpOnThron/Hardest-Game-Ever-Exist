using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Spikes_kill : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		

	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if( collision.gameObject.tag == "Player" )
		{
			SceneManager.LoadScene("Level1");
		}
	}


}
