using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffColision : MonoBehaviour
{
    public GameObject mainSquare;
    BoxCollider2D boxColider;

    void Update()
    {
        boxColider = GetComponent<BoxCollider2D>();
        check();
    }
   
    private void check()
    {
      if( transform.position.y > mainSquare.transform.position.y )
        {
            
                boxColider.enabled = false;
        }
        if (transform.position.y < mainSquare.transform.position.y - 0.6f)
        {
            boxColider.enabled = true;
        }
    }
 

}
