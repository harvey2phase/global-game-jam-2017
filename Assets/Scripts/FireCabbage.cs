using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCabbage : MonoBehaviour {
    public GameObject preFab;
	
	void Start () {	}
	
	void Update () {

    }

    public bool LaunchCabbage(float x, float y)
    {

        GameObject clone = Instantiate<GameObject>(preFab, new Vector2(x, y), Quaternion.identity);
        clone.gameObject.SetActive(true);
        Debug.Log("The clone was instantiated");
        Debug.Log(gameObject.transform.position.ToString());
        clone.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0f);
        return true;
    }
}
/*new Transform(GetComponent<Rigidbody2D>().transform.position.x, GetComponent<Rigidbody2D>().transform.position.y)*/
/*GetComponent<Rigidbody2D>().transform.position*/