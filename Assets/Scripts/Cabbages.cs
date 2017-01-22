
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cabbages : MonoBehaviour {
    public const int MAX_CABBAGES = 5;
    public int currentCabbages;

    public GameObject cabbage;

    public float CooldownTime = 2;
    public float LifeTime = 2;
    public float GrowPercentage = .01f;
    public int Speed = 1500;

    // Use this for initialization
    void Start () {
        currentCabbages = 3;
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
            var clone = Instantiate(cabbage, transform.position, Quaternion.Euler(0, 0, 90));//(transform.rotation));
            clone.GetComponent<Rigidbody2D>().AddForce(new Vector2(Speed, 0));
            Destroy(clone, 1000);

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
            //add the image??
            return true;
        }
        
    }
}

internal class GravityWangravityWave
{
}