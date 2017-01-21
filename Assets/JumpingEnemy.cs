using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingEnemy : BaseEnemy {

    float timeUntilJump;

    // Use this for initialization
    void Start () {
        timeUntilJump = Random.value * 10;
    }
    
    // Update is called once per frame
    void Update () {
        Move();

        timeUntilJump -= Time.deltaTime;

        Jump();
    }

    public override void Move()
    {
        GetComponent<Transform>().Translate(-.2f, 0, 0);
    }

    void Jump()
    {

        if(timeUntilJump <= 0)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * 2000);
            timeUntilJump = Random.value * 10;
        }
    }

    public override void Attack()
    {

    }

    public override void PlayerInRange()
    {

    }
}
