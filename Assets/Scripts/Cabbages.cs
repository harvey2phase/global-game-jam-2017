
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cabbages : MonoBehaviour {
    public const int MAX_CABBAGES = 5;
    public int currentCabbages = 3;

    public GameObject cabbage;
    public AudioController audio;

    public float CooldownTime = 2;
    public float LifeTime = 2;
    public float GrowPercentage = .01f;
    public int Speed = 1500;

    // Use this for initialization
    void Start() {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            throwCabbage();
        }
        if (Input.GetKeyDown(KeyCode.F) == true)
        {

        }
        if (Input.GetKeyDown(KeyCode.C) == true)
        {
            consumeCabbage();
        }
    }
    public void incrementCabbages()
    {
        currentCabbages++;

        if (currentCabbages > MAX_CABBAGES)
        {
            currentCabbages = MAX_CABBAGES;
        }
    }

    public void decrementCabbages()
    {
        currentCabbages--;
    }

    public bool throwCabbage()
    {
        //The amount of cabbages is never above MAX_CABBAGES
        if (currentCabbages <= 0)
        {
            return false; //Don't throw if you don't have cabbages
        }
        else {
            decrementCabbages();

            //Launch the cabbage
            SpriteRenderer sprite = GetComponent<SpriteRenderer>();
            bool direction = sprite.flipX; //If true, the player is facing left
                if (direction)
                {
                    Speed = Mathf.Abs(Speed)*(-1);
                }
            else
            {
                Speed = Mathf.Abs(Speed);
            }
            var clone = Instantiate(cabbage, transform.position, Quaternion.Euler(0, 0, 90));//(transform.rotation));
            audio.PlayThrowCabbageClip();
            clone.GetComponent<Rigidbody2D>().AddForce(new Vector2(Speed, 0));
            Destroy(clone, 2);

            return true;
        }
    }

    public bool pickUpCabbage()
    {
        if (currentCabbages >= MAX_CABBAGES)
        {
            return false;
        }
        else
        {
            incrementCabbages();
            audio.PlayCabbagePickupClip();
            return true;
        }

    }

    public bool consumeCabbage()
    {
        if(currentCabbages == 0)
        {
            return false;
        }
        else
        {
            decrementCabbages();
            gameObject.GetComponent<Health>().changeHealth(10);
            audio.PlayHealthReplenishClip();
            return true;
        }
    }
}

internal class GravityWangravityWave
{
}