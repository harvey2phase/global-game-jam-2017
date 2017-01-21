using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPanel : MonoBehaviour {
    public Health health;
    RectTransform powerUpRect;
    Vector2 defaultAnchorMin;
    Vector2 defaultAnchorMax;

    void Start()
    {
        powerUpRect = GetComponent<RectTransform>();
        defaultAnchorMin = powerUpRect.anchorMin;
        defaultAnchorMax = powerUpRect.anchorMax;
    }
	
	void Update () {
        Vector2 newVector = new Vector2();
        newVector.x = defaultAnchorMax.x - (defaultAnchorMax.x - defaultAnchorMin.x) * (health.health - 100) / 20;
        newVector.y = defaultAnchorMin.y;
        powerUpRect.anchorMin = newVector;
    }

    public bool endHealthPowerUp()
    {
        /*
        powerUpRect.Set(defaultAnchorMax.y, defaultAnchorMin.y);
        */return true;
        
    }
}
