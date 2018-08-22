﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meteor_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Player") {
			SceneManager.LoadScene ("Level1");
		} 
		else if (collision.gameObject.tag == "Ground") {
			DestroyObject(gameObject);
		}
		else if (collision.gameObject.name == "shield") {
			DestroyObject(gameObject);
		}
	}
}
