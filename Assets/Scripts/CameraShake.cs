using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    private float startTime = 0;
    private float angle = 0;
    private bool isShaking;
    private Camera cam;
    private int severity;
    private int speed;

	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
        speed = 25;
        severity = 10;
        isShaking = false;
        //StartCoroutine(wait(3));
	}

    IEnumerator wait(float seconds)
    {
        startTime = Time.time;
        isShaking = true;
        //print("Start");
        yield return new WaitForSeconds(seconds);
        //print("Stop");
        isShaking = false;
        cam.transform.eulerAngles = new Vector3(0, 0, 0);
    }

    public void shake(float duration)
    {
        shake(duration, 10, 25);
    }

    public void shake(float duration, int severity, int speed)
    {
        this.severity = severity;
        this.speed = speed;
        StartCoroutine(wait(duration));
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P) == true)
        {
            shake(1);
        }

		if (isShaking == true)
        {
            angle = (Mathf.Sin((startTime - Time.time)*speed))*severity;
            cam.transform.eulerAngles = new Vector3(0, 0, angle);
        }
	}
}
