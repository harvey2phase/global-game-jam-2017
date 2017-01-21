using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabbages : MonoBehaviour {
    const int MAX_CABBAGES = 5;
    public int currentCabbages
    {
        get;
        private set;
    }
	// Use this for initialization
	void Start () {
        currentCabbages = 5;
	}

    public void incrementCabbages()
    {
        currentCabbages++;
    }

    public void decrementCabbages()
    {
        currentCabbages--;
    }

    public void throwCabbage()
    {

    }

    public void pickupCabbage()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
