using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    const int MAX_HEALTH = 100;

    public int health;

    bool IncrementHealth(int value)
    {
        health += value;
        if (health > MAX_HEALTH)
        {
            health = MAX_HEALTH;
            return false;
        }
        return true;
    }


    bool DecrementHealth(int value)
    {
        health -= value;
        return (health <= 0);
    }

    // Use this for initialization
    void Start () {
        health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
