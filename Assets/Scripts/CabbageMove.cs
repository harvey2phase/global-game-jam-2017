using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabbageMove : MonoBehaviour {
    public Vector2 ProjSpeed;
    public Vector2 Speed;
    private Vector2 movement;
    float inputX;
    float inputY;
    //Rigidbody2D rigidbody2D;

    // Use this for initialization
    void Start () {
        this.gameObject.SetActive(true);
        Speed = new Vector2(2f, 0f);
        gameObject.GetComponent<Rigidbody2D>().velocity = Speed;
        GetComponent<Rigidbody2D>().velocity = Speed;
    }
	
	// Update is called once per frame
	void Update () {
        //gameObject.GetComponent(transform.position.x) = 
        movement = new Vector2(Speed.x * inputX, Speed.y * inputY);

    }
}
