using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
	
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
			GetComponent<Rigidbody2D> ().AddForce (transform.up * 300);
	}
}
