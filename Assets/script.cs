using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
	
	bool isKeyUp;

	// Use this for initialization
	void Start () {
		isKeyUp = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
			GetComponent<Rigidbody2D> ().AddForce (transform.up * 300);
	}
}
