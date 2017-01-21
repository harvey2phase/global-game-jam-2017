using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveAttack : MonoBehaviour {
    public bool isFiring
    {
        get;
        private set;
    }

    // Use this for initialization
    void Start () {
        isFiring = false;
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            isFiring = true;
        }
    }
}
