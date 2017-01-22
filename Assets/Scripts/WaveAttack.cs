using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveAttack : MonoBehaviour {

    public SpriteRenderer circle;
    public bool IsFiring
    {
        get;
        private set;
    }
    public int Range;

    public int Force;
    public Vector2 PositionOnFire
    {
        get;
        private set;
    }

    // Use this for initialization
    void Start () {
        IsFiring = false;
        PositionOnFire = transform.position;

        circle.transform.localScale = new Vector3(Range / 10, Range / 10, Range);
        circle.gameObject.SetActive(false);
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            circle.gameObject.SetActive(true);
            IsFiring = true;
            PositionOnFire = transform.position;
        }
        else
        {
            circle.gameObject.SetActive(false);
            IsFiring = false;
        }
    }
}
