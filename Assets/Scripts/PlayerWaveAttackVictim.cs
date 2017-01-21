using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWaveAttackVictim : MonoBehaviour
{
    public WaveAttack Attacker;
    public GameObject Victim;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Attacker.isFiring)
        {
            GameObject Enemy = Attacker.gameObject;
            double distance = Vector2.Distance(Victim.transform.position, Attacker.PositionOnFire);
            bool isInRange = distance <= Attacker.range;
            int distanceMultiplier = 0;
            int directionOfMovement = (Attacker.PositionOnFire.x < Victim.transform.position.x) ? 1 : -1;
            if (!isInRange)
            {
                distanceMultiplier = 0;
            }
            else if (isInRange)
            {
                distanceMultiplier = 1;
            }
            //Can do more thresholds and stuff, need to know that scale first.

            //These are dummy values as well, also distance travelled should de
            Debug.Log(distanceMultiplier);
            Victim.GetComponent<Rigidbody2D>().AddForce(Vector2.up * distanceMultiplier * 10);
            Victim.GetComponent<Rigidbody2D>().AddForce(Vector2.right * distanceMultiplier * directionOfMovement * 10);
        }
    }
}