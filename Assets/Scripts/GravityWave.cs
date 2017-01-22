using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityWave : MonoBehaviour {

    private GameObject[] waveSet;

    private GameObject wave;

    private Transform launchPoint;
    private int currentWave;
    private int maxWaves = 4;

    public float CooldownTime = 2;
    public float LifeTime = 2;
    public float GrowPercentage = .01f;
    public int Speed = 1500;

	// Use this for initialization
	void Start () {
        wave = Instantiate(Resources.Load("Gravity", typeof(GameObject))) as GameObject;
        wave.AddComponent<Rigidbody2D>();
        wave.GetComponent<Rigidbody2D>().gravityScale = 0;
        waveSet = new GameObject[maxWaves];
        currentWave = 0;
	}
	
	// Update is called once per frame
	void Update () {
        
        /*
        for (int i = 0; i < maxWaves; i++)
        {
            if (waveSet[i] != null)
            {
                //print("Increasing size!");
                float scale = waveSet[i].transform.localScale.x;
                waveSet[i].transform.localScale += new Vector3(GrowPercentage, GrowPercentage, GrowPercentage);
            }
        }
        */
    }
    public bool LaunchCabbage()
    {
        var clone = Instantiate(wave, transform.position, Quaternion.Euler(0, 0, 90));//(transform.rotation));
        clone.GetComponent<Rigidbody2D>().AddForce(new Vector2(Speed, 0));
        waveSet[currentWave++] = clone;
        if (currentWave >= maxWaves) currentWave = 0;
        Destroy(clone, LifeTime);
        return true;
    }

}
