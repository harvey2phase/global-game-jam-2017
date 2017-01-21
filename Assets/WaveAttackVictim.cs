using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveAttackVictim : MonoBehaviour {

    public WaveAttack attacker;
    public GameObject victim;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(attacker.isFiring)
        {
            GameObject player = attacker.gameObject;
            double distance = Vector2.Distance(victim.transform.position, attacker.PositionOnFire);
            bool isInRange = distance <= attacker.range;
            int distanceMultiplier = 0;
            int directionOfMovement = (attacker.PositionOnFire.x < victim.transform.position.x) ? 1 : -1;
            if(!isInRange)
            {
                distanceMultiplier = 0;
            }
            else if(isInRange)
            {
                distanceMultiplier = 1;
            }
            //Can do more thresholds and stuff, need to know that scale first.

            //These are dummy values as well, also distance travelled should de
            Debug.Log(distanceMultiplier);
            victim.GetComponent<Rigidbody2D>().AddForce(Vector2.up * distanceMultiplier * 10);
            victim.GetComponent<Rigidbody2D>().AddForce(Vector2.right * distanceMultiplier * directionOfMovement * 10);
        }
	}
}
