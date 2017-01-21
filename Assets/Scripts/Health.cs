using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public PowerUpPanel powerUpPanel;
    public int health; //Health is out of 100
    public bool powerUpIsActive = false;

    public CanvasRenderer LosingScreen;

    // Use this for initialization
    void Start() {
        health = 100;
        powerUpIsActive = false;
        LosingScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update() {

    }
    /**
     * Changes the health by the difference.
     * Returns the new health level.
     */
    public int changeHealth(int difference)
    {
        health += difference;
        moderateHealth(); //Make sure health is in correct range
        return health;
    } 

    /**
     * Increases health by 10
     */
    public int incrementHealth()
    {
        health += 10;
        moderateHealth(); //Make sure health is never greater than 100
        return health;
    }
    /**
     * Decreases health by 10
     * Returns new health level
     * Health never goes below 0
     */
    public int decrementHealth()
    {
        health -= 10;
        moderateHealth(); //Make sure health is never less than 0
        return health;
    }

    /**
     * Increases health to 120 and renders the extra health bar
     */
     public bool getPowerUp()
    {
        powerUpIsActive = true;
        health = 120;
        powerUpPanel.gameObject.SetActive(true);
        return true;
    }
   
    /**
     * Make sure health is in a valid range
     * Takes power-ups into consideration
     */
    public bool moderateHealth()
    {
        if (powerUpIsActive)
        {
            if (health > 120)
            {
                health = 120;
            }
            if(health <= 100)
            {
                //Makes the extra health box dissappear and changes the powerUpHealth bool
                powerUpPanel.gameObject.SetActive(false);
                powerUpIsActive = false;
            }
        }
        else
        {
            if (health > 100)
            {
                health = 100;
            }
        }

        Debug.Log(health);

        if (health <= 0)
        {
            LosingScreen.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        return true;
    }
}
