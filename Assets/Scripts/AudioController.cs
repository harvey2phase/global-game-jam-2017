using System.Collections;
using UnityEngine;

public class AudioController : MonoBehaviour {
    public AudioClip TurtleJumping;
    public AudioClip TurtleMoving;
    public AudioClip TurtleHurt;

    public AudioClip SnakeHiss;
    public AudioClip HealthReplenish;
    public AudioClip ThrowCabbage;
    public AudioClip CabbagePickup;

    public AudioClip Earthquake;

    bool IsMoving;

    // Use this for initialization
    void Start () {
        IsMoving = false;
    }
    
    // Update is called once per frame
    void Update () {
        
    }

    public void PlayJumpClip()
    {
        GetComponent<AudioSource>().clip = TurtleJumping;
        GetComponent<AudioSource>().Play();
    }

    public void PlaySnakeClip()
    {
        GetComponent<AudioSource>().clip = SnakeHiss;
        GetComponent<AudioSource>().Play();
    }

    public void PlayHurtClip()
    {
        GetComponent<AudioSource>().clip = TurtleHurt;
        GetComponent<AudioSource>().Play();
    }

    public void PlayEarthquakeClip()
    {
        GetComponent<AudioSource>().clip = Earthquake;
        GetComponent<AudioSource>().Play();
    }

    public void PlayHealthReplenishClip()
    {
        GetComponent<AudioSource>().clip = HealthReplenish;
        GetComponent<AudioSource>().Play();
    }

    public void PlayThrowCabbageClip()
    {
        GetComponent<AudioSource>().clip = ThrowCabbage;
        GetComponent<AudioSource>().Play();
    }

    public void PlayCabbagePickupClip()
    {
        GetComponent<AudioSource>().clip = CabbagePickup;
        GetComponent<AudioSource>().Play();
    }
    /*
     * public void StartMoveClip()
    {
        GetComponent<AudioSource>().clip = TurtleMoving;
        if(!IsMoving)
        {
            StartCoroutine(playMovement());
        }
        IsMoving = true;
    }

    IEnumerator playMovement()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        if(IsMoving)
        {
            StartCoroutine(playMovement());
            IsMoving = false;
        }
    }*/
}
