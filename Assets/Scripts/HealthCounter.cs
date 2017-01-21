using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCounter : MonoBehaviour {
    public Health health;

    Vector2 defaultAnchorMin;
    Vector2 defaultAnchorMax;

    RectTransform rect;
    RectTransform powerUpRect;

    // Use this for initialization
    void Start () {
        rect = GetComponent<RectTransform>();
        powerUpRect = GetComponent<RectTransform>();
        defaultAnchorMin = rect.anchorMin;
        defaultAnchorMax = rect.anchorMax;
    }

    // Update is called once per frame
    void Update () {
        Vector2 newVector = new Vector2();
        newVector.x = defaultAnchorMax.x - (defaultAnchorMax.x - defaultAnchorMin.x) * (health.health) / 100;
        newVector.y = defaultAnchorMin.y;
        rect.anchorMin = newVector;
    }
}
