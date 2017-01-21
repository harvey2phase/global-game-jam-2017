using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour {
    public Rigidbody2D rigedBod;
    public double time
    {
        get;
        private set;
    }
	// Use this for initialization
	void Start () {
        rigedBod = GetComponent<Rigidbody2D>();
        rigedBod.gravityScale = 0f;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
