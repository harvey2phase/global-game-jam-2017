/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cabbages : MonoBehaviour {
    public const int MAX_CABBAGES = 5;

    public int currentCabbages;

	// Use this for initialization
	void Start () {
        currentCabbages = 3;
	}
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            throwCabbage();
        }
    }
    public void incrementCabbages()
    {
        currentCabbages++;
        
        if (currentCabbages > MAX_CABBAGES)
        {
            currentCabbages = MAX_CABBAGES;
        }
    }

    public void decrementCabbages()
    {
        currentCabbages--;
    }

    public bool throwCabbage()
    {
        //The amount of cabbages is never above MAX_CABBAGES
        if (currentCabbages <= 0)
        {
            return false; //Don't throw if you don't have cabbages
        }
        else {
            decrementCabbages();
            //Launch the cabbage
            return true;
        }
    }

    public bool pickUpCabbage()
    {
        if (currentCabbages >= MAX_CABBAGES)
        {
            return false;
        }
        else
        {
            incrementCabbages();
            //add the image??
            return true;
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
*/