using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject target = collider.gameObject;

        if (target.tag == "Player")
        {
            target.GetComponent<Health>().decrementHealth(200);
        }
        else Destroy(target);
    }
}
