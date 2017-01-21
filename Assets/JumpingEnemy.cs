using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingEnemy : BaseEnemy {
    GameObject victim;

    float timeUntilJump;

    bool grounded;

    // Use this for initialization
    void Start () {
        grounded = true;
        timeUntilJump = Random.value * 10;
        victim = null;
    }
    
    // Update is called once per frame
    void FixedUpdate () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 1000f, 1 << 8);

        // grounded?
        if (hit.distance < 2f)
            grounded = true;
        else
            grounded = false;

        Move();

        Attack();

        timeUntilJump -= Time.deltaTime;

        NormalizeSlope();

        Jump();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        victim = collision.gameObject;
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

    void NormalizeSlope()
    {
        // Attempt vertical normalization
        if (grounded)
        {
            int layerMask = 1 << 8;
            RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 1000f, layerMask);

            if (hit.collider != null && Mathf.Abs(hit.normal.x) > 0.1f)
            {
                Transform pos = GetComponent<Transform>();
                Rigidbody2D body = GetComponent<Rigidbody2D>();

                float friction = 2f;

                // Apply the opposite force against the slope force 
                // You will need to provide your own slopeFriction to stabalize movement
                body.velocity = new Vector2(body.velocity.x - (hit.normal.x * friction), body.velocity.y);

                //Move Player up or down to compensate for the slope below them
            }
        }
    }
    public override void Attack()
    {
        Debug.Log(victim);
        if(victim != null)
        {
            Health hp = victim.GetComponent<Health>();

            if(hp != null)
            {
                hp.decrementHealth();
            }

            victim = null;
        }
    }

    public override void PlayerInRange()
    {

    }
}
