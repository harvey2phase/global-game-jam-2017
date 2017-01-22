using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingEnemy : BaseEnemy {
    GameObject victim;

    public float JumpInterval = 5f;

    public float HissInterval = 10f;

    public AudioController audio;

    float timeUntilJump;
    float timeUntilHiss;

    bool grounded;

    // Use this for initialization
    void Start () {
        grounded = true;
        timeUntilJump = Random.value * JumpInterval;
        timeUntilHiss = Random.value * HissInterval;
        victim = null;

        audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>();
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

        Hiss();

        timeUntilJump -= Time.deltaTime;
        timeUntilHiss -= Time.deltaTime;

        NormalizeSlope();

        Jump();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        victim = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        victim = null;
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
            timeUntilJump = Random.value * JumpInterval;
        }
    }

    void Hiss()
    {
        if(timeUntilHiss <= 0)
        {
            audio.PlaySnakeClip();
            timeUntilHiss = Random.value * HissInterval;
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
        if(victim != null)
        {
            Health hp = victim.GetComponent<Health>();

            if(hp != null)
            {
                hp.decrementHealth();
            }
        }
    }

    public override void PlayerInRange()
    {

    }
}
