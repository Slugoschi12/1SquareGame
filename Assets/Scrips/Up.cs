using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Up : MonoBehaviour
{   //pentru deathZone
    bool onOff;
    public bool DeathZoneOff = false;
    void Start()
    {   
        int deathZoneOff = PlayerPrefs.GetInt("deathZoneOff", 0);
        if (deathZoneOff == 0)
          onOff= true;
        else onOff= false;

    }

    // Update is called once per frame
    void Update()
    {   if(onOff)
            transform.position = new Vector3(transform.position.x, transform.position.y +0.001f , transform.position.z); 
        else 
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "MainSquare")
        {
            DeathZoneOff = true;
        }
    }
}
