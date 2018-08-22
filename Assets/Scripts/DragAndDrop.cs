using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour 
{
	void OnMouseDrag()
	{
		Vector3 currentPos = transform.position;
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 10;
		mousePos = Camera.main.ScreenToWorldPoint (mousePos);
		transform.position = new Vector3 (mousePos.x, mousePos.y, 0);
		GetComponent<Rigidbody2D> ().gravityScale = 0;
	}

	void OnMouseUp()
	{
		GetComponent<Rigidbody2D> ().gravityScale = 1;
	}
}