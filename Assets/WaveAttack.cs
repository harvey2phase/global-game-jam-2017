using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveAttack : MonoBehaviour {
    public GameObject Player;
    public bool isFiring
    {
        get;
        private set;
    }
    public int range
    {
        get;
        set;
    }
    public Vector2 PositionOnFire
    {
        get;
        private set;
    }

	// Use this for initialization
	void Start () {
        isFiring = false;
        PositionOnFire = Player.transform.position;
        range = 200;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            isFiring = true;
        }
	}
}
