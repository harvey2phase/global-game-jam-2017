using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatScript : MonoBehaviour {
    public GameObject ocean;
    public GameObject boatStandard;
    public GameObject player;
    public bool isLoaded = false;

	// Use this for initialization
	void Start () {
        boatStandard = Instantiate(Resources.Load("Boat", typeof(GameObject))) as GameObject;
        //boatStandard = Resources.Load("Boat", typeof(GameObject));

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        print("Touched!");
        if (isLoaded == false)
        {
            if (other.gameObject.tag == "Player")
            {
                print("Player touched!");
                
                player = other.gameObject;
                isLoaded = true;
                var clone = Instantiate(boatStandard, transform.position, Quaternion.Euler(0, 0, 0));
                clone.transform.SetParent(player.transform);
                clone.AddComponent<DistanceJoint2D>();
                clone.GetComponent<DistanceJoint2D>().connectedBody = player.GetComponent<Rigidbody2D>();
                clone.transform.position = player.transform.position - new Vector3(0, 1.4f, 0);
                clone.AddComponent<Rigidbody2D>();
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
