using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {

	static readonly float interval = 2f;
	float currentTime = interval;

	public GameObject prefab;

	void Start() {
		for (int i = 0; i < 3; i++)
			Instantiate(prefab, new Vector2(i, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		currentTime -= Time.deltaTime;

		if (currentTime < 0) {
			Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
			currentTime = interval;
		}
	}
}