using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BobMove : MonoBehaviour
{

    public Rigidbody2D player;
    public static int speed_unit = 10;
    public Vector2 speed = new Vector2(speed_unit, 0);

    // Use this for initialization
    void Start()
    {
        player = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
		GetComponent<Animator> ().SetBool ("IsRunning",true);
        player.freezeRotation = true;

    }

    // Update is called once per frame
    void Update()
    {
        player.velocity = speed;
		if (gameObject.transform.position.y < -7)
		{
			SceneManager.LoadScene("Level1");

		}
        

    }

	void OnCollisionEnter2D (Collision2D col)
	{
		RaycastHit2D RayRight = Physics2D.Raycast(transform.position, Vector2.right);

		if (RayRight.collider.tag == "Spikes") {
			Debug.Log ("Collide");
		}
	}

}
