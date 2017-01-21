using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPanel : MonoBehaviour {
    public Health health;
    RectTransform powerUpRect;
    /*
    Vector2 defaultAnchorMin;
    Vector2 defaultAnchorMax;
    */
    void Start()
    {
        powerUpRect = GetComponent<RectTransform>();
        gameObject.SetActive(false);

        /*
        defaultAnchorMin = powerUpRect.anchorMin;
        defaultAnchorMax = powerUpRect.anchorMax;
        */
    }
	
	void Update () {
        /*
        Vector2 newVector = new Vector2();
        newVector.x = defaultAnchorMax.x - (defaultAnchorMax.x - defaultAnchorMin.x) * (health.health - 100) / 20;
        newVector.y = defaultAnchorMin.y;
        powerUpRect.anchorMin = newVector;
        */
    }
    /**
     * Makes the extra health box dissappear and changes the powerUpHealth bool
     */
    public bool endHealthPowerUp()
    {
        GetComponent<MeshRenderer>().enabled = false;
        return true;
    }
}
