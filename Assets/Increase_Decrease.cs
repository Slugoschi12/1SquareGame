using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Increase_Decrease : MonoBehaviour
{
    GameObject[] obj;
    public ChangeColor[] color;
    private void Start()
    {
        obj = GameObject.FindGameObjectsWithTag("Interact");

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "MainSquare" && gameObject.tag == "Decrease")
        {   
            foreach(ChangeColor cl in color)
            
                cl.levelSquare -= 1;
            Destroy(gameObject);
        }
       
        if (col.gameObject.tag == "MainSquare" && gameObject.tag == "Increase")
        {
            foreach (ChangeColor cl in color)

                cl.levelSquare += 1;
            Destroy(gameObject);
        }

        
    }
}
