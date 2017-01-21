using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveAttack : MonoBehaviour {
    public bool IsFiring
    {
        get;
        private set;
    }
    public int Range;

    public int Force;
    public Vector2 PositionOnFire
    {
        get;
        private set;
    }

    // Use this for initialization
    void Start () {
        IsFiring = false;
        PositionOnFire = transform.position;
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            IsFiring = true;
            PositionOnFire = transform.position;
        }
        else
        {
            IsFiring = false;
        }
    }
}
