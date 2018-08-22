using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blade : MonoBehaviour {
	
	public Rigidbody2D blader;
	public static int speed_unit = -10;
	public Vector2 speed = new Vector2(speed_unit, 0);

	// Use this for initialization
	void Start () {
		blader.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
		blader.velocity = speed;

	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if( collision.gameObject.tag == "Player" )
		{
			SceneManager.LoadScene("Level1");
		}
	}

	public void die(){
		DestroyObject(gameObject);
	}
}
