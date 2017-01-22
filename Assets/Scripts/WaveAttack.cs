using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveAttack : MonoBehaviour {

    public float cooldownTime
    {
        get;
        set;
    }
    public float time;
    public float timeHeld;
    public bool hasBeenPressed;
    public bool onCoolDown;
    
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
        hasBeenPressed = false;
        onCoolDown = false;
        PositionOnFire = transform.position;
        cooldownTime = 3;
        time = 0;
        timeHeld = 0;

        circle.transform.localScale = new Vector3(Range / 10, Range / 10, Range);
        circle.gameObject.SetActive(false);
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Space) && !onCoolDown && timeHeld < 3)
        {
            hasBeenPressed = true;
            timeHeld += Time.deltaTime;
            circle.gameObject.SetActive(true);
            IsFiring = true;
            PositionOnFire = transform.position;
        }
        else
        {
            if (hasBeenPressed)
            {
                time += Time.deltaTime;
                onCoolDown = true;
            }
            if (time > cooldownTime)
            {
                hasBeenPressed = false;
                onCoolDown = false;
                time = 0;
                timeHeld = 0;
            }
            circle.gameObject.SetActive(false);
            IsFiring = false;
        }
    }
}
