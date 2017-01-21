using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    
    bool isKeyLeft, isKeyRight, grounded, jumped;

    // Use this for initialization
    void Start () {
        isKeyLeft = false;
        isKeyRight = false;
        grounded = true;
        jumped = false;
    }
    
    // Update is called once per frame
    void Update () {

        // grounded?
        if(GetComponent<Rigidbody2D>().velocity.y == 0)
            grounded = true;
        if(GetComponent<Rigidbody2D>().velocity.y != 0)
            grounded = false;

        float Y = GetComponent<Rigidbody2D> ().velocity.y;

        // jump
        if (Input.GetKeyDown (KeyCode.UpArrow) && Y < 0.000000001) {
            GetComponent<Rigidbody2D> ().AddForce (transform.up * 2000);
        }
        
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