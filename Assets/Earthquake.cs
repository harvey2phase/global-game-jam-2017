using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthquake : MonoBehaviour {

	public float interval = 2f;
	float currentTime;

	// Use this for initialization
	void Start () {
		currentTime = interval;
	}
	
	// Update is called once per frame
	void Update () {

		currentTime -= Time.deltaTime;

		if (currentTime < 0) {
			
			for (int i = 0; i < 10; i++) {
				this.gameObject.transform.Rotate(Vector3.down * Time.deltaTime);
			}
		}
	}
}