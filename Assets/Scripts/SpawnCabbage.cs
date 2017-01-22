using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCabbage : MonoBehaviour {

    public int NumberOfCabbages = 3;
    public GameObject CabbagePickUp;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < NumberOfCabbages; i++)
        {
            float coords = Random.value * 280 - 140;
            Instantiate(CabbagePickUp, new Vector2(coords, 100), Quaternion.identity);
        }
            
    }

    // Update is called once per frame
    void Update () {
        
    }
}
