using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveAttackVictim : MonoBehaviour {

    public WaveAttack attacker;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(attacker.isFiring)
        {
            GameObject player = attacker.gameObject;

            double distance = Math.Pow(Vector2.Dot(player.transform.position, attacker.transform.position), 2);

        }
	}
}
