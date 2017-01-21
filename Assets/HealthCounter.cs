﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCounter : MonoBehaviour {
    public int health = 100;

    Vector2 defaultAnchorMin;
    Vector2 defaultAnchorMax;

    RectTransform rect;

    // Use this for initialization
    void Start () {
        rect = GetComponent<RectTransform>();
        defaultAnchorMin = rect.anchorMin;
        defaultAnchorMax = rect.anchorMax;
    }

    // Update is called once per frame
    void Update () {
        Vector2 newVector = new Vector2();
        newVector.x = defaultAnchorMax.x - (defaultAnchorMax.x - defaultAnchorMin.x) * (health) / 100;
        newVector.y = defaultAnchorMin.y;
        rect.anchorMin = newVector;
    }
}