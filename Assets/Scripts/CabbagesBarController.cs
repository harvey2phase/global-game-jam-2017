using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CabbagesBarController : MonoBehaviour {
    public Image[] CabbageImages;
    public Cabbages Player; // This is attached to the player
	
    // Use this for initialization
	void Start () {
        foreach(Image img in CabbageImages)
        {
            img.gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Image img in CabbageImages)
        {
            img.gameObject.SetActive(false);
        }
  
        for (int i = 0; i < Player.currentCabbages; i++)
        {
            CabbageImages[i].gameObject.SetActive(true);
        }
	}

}
