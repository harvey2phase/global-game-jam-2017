using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumController : MonoBehaviour
{
    public Rigidbody2D Pendulum;
    public double currentTime
    {
        get;
        private set;
    }
    // Use this for initialization
    void Start()
    {
        Pendulum = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if ((int)currentTime == 2)
        {
            Pendulum.AddForce(Vector2.right * 1.20f);
        }
    }
}