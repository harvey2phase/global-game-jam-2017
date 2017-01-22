using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnemyHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
        //If the collider is the player
        if (other.gameObject.tag == "CabbageProjectile")
        {
            //Destroy the cabbage and the enemy
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
