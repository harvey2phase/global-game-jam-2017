using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CabbagesBarController : MonoBehaviour {
    public Image[] Cabbages;
    public Cabbages Player;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        /*int element = (Player.currentCabbages - 1);
        if (Player.pickupCabbage() && element != (Player.maxCabbages - 1))
        {
            Cabbages[element].enabled = true;
        }
        else if(Player.throwCabbage())
        {
            Cabbages[element].enabled = false;
        }*/
	}
}
