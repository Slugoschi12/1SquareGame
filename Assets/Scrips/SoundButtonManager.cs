using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButtonManager : MonoBehaviour
{
    public AudioClip platforma;
    public AudioClip squareNr;
    public AudioClip increase_decrease;
/*  public AudioClip rightAngle;
    public AudioClip squareNr;*/
    public AudioSource audioSrc;

    void OnCollisionEnter2D(Collision2D col)
    {   
        if(col.gameObject.tag == "Interact")
             audioSrc.PlayOneShot(squareNr);
        if (col.gameObject.tag == "Platforma_1")
            audioSrc.PlayOneShot(platforma);
        if (col.gameObject.tag == "Increase" || col.gameObject.tag == "Decrease")
            audioSrc.PlayOneShot(increase_decrease);
    }
}
