using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBehaviour : MonoBehaviour {
    private const int RANGE = 50;
    private int health;
    private GameObject player;
	// Use this for initialization
	void Start () {
        health = 5;
	}
	
	// Update is called once per frame
	void Update () {
        //float distance = Vector3.Distance(gameObject.transform, gameObject.transform.Parent["Red Box"].transform);
        //print(distance);
	}
}
