using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveAttackVictim : MonoBehaviour {

    public WaveAttack attacker;

    // Use this for initialization
    void Start () {
        attacker = GameObject.FindGameObjectWithTag("Player").GetComponent<WaveAttack>();
    }
    
    // Update is called once per frame
    void Update () {
        if (attacker.IsFiring)
        {
            GameObject player = attacker.gameObject;
            double distance = Vector2.Distance(gameObject.transform.position, attacker.PositionOnFire);
            bool isInRange = distance <= attacker.Range;
            int distanceMultiplier = 0;
            int directionOfMovement = (attacker.PositionOnFire.x < gameObject.transform.position.x) ? 1 : -1;
            if (!isInRange)
            {
                distanceMultiplier = 0;
            }
            else if (isInRange)
            {
                distanceMultiplier = 1;
            }
            //Can do more thresholds and stuff, need to know that scale first.

            //These are dummy values as well, also distance travelled should de
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * distanceMultiplier * attacker.Force);
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * distanceMultiplier * directionOfMovement * attacker.Force);
        }
    }
}
