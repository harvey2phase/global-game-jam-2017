using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPickUp : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Cabbage is picked up");
        //If the collider is the player
        if(other.gameObject.tag == "Player")
        {
            //Tell the player that they picked up another cabbage
            other.GetComponent<Cabbages>().pickUpCabbage();
            
            gameObject.SetActive(false);//Disappear
            Destroy(gameObject);
        }
    }
}