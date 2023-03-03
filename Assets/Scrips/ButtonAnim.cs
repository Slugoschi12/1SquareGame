using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnim : MonoBehaviour
{
    public  AudioClip pressButtonLevel;
    public AudioSource audioSrc;
    public void soundButton()
    {
        audioSrc.PlayOneShot(pressButtonLevel);
    }

    public void button_anim(string nameAnim)
    {
        GetComponent<Animation>().Play(nameAnim);
    }

}
