using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
	
	bool isKeyLeft, isKeyRight;

	// Use this for initialization
	void Start () {
		isKeyLeft = false;
		isKeyRight = false;
	}
	
	// Update is called once per frame
	void Update () {

		// jump
		if (Input.GetKeyDown(KeyCode.UpArrow))
			GetComponent<Rigidbody2D> ().AddForce (transform.up * 500);
		
		// move left
		if (Input.GetKeyDown (KeyCode.LeftArrow))
			isKeyLeft = true;
		if (Input.GetKeyUp (KeyCode.LeftArrow))
			isKeyLeft = false;
		if (isKeyLeft == true)
			this.gameObject.transform.Translate (-(float).25, 0, 0);

		// move right
		if (Input.GetKeyDown (KeyCode.RightArrow))
			isKeyRight = true;
		if (Input.GetKeyUp (KeyCode.RightArrow))
			isKeyRight = false;
		if (isKeyRight == true)
			this.gameObject.transform.Translate ((float).25, 0, 0);
	}
}