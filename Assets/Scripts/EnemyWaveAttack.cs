using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaveAttack : MonoBehaviour
{
    public GameObject Enemy;
    double currentTime;
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
    public int fireTime
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
    void Start()
    {
        PositionOnFire = Enemy.transform.position;
        range = 200;
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if ((int)currentTime == 10)
        {
            isFiring = true;
            currentTime = 0;
        }
        else
        {
            isFiring = false;
        }
    }
}