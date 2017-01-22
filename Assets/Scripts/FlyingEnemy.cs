using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : BaseEnemy
{
    GameObject victim;
    public bool InRange;
    float timeUntilJump;
    public GameObject Player;

    // Use this for initialization
    void Start()
    {
        timeUntilJump = Random.value * 5;
        victim = null;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector2.Distance(transform.position, Player.transform.position);

        // grounded?
        print("Distance: "+distance);
        if (distance < 15)
            InRange = true;
        else
            InRange = false;

        timeUntilJump -= Time.deltaTime;
        if (timeUntilJump < 0)
        {
            Swoop();
            timeUntilJump = Random.value * 5;
        }
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

    void Swoop()
    {
        //GetComponent<Rigidbody2D>().AddForce(transform.up * -20);
        timeUntilJump = Random.value * 5;
        print("Swooped!");
    }

    public override void Attack()
    {
        if (victim != null)
        {
            Health hp = victim.GetComponent<Health>();

            if (hp != null)
            {
                hp.decrementHealth();
            }
        }
    }

    public override void PlayerInRange()
    {

    }
}
