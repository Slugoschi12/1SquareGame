using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Vector2 poz;
    public float aplitudineX;
    public float aplitudineY;
    public float frecventa;
    public bool jump;
    public bool groundcol ;
 
    private void Start()
    {
      poz = transform.position;

        groundcol = false;
    }
    private void Update()
    {
        Move();
    }
    public void Move()
    {
        float MaxX = Input.GetAxisRaw("Horizontal");
        if(MaxX == -1)
        {
            jump = true;
        }

        if (jump && groundcol)
        {
            float ySin = Mathf.Sin(Time.time * frecventa) * aplitudineY;
            float xSin = Mathf.Cos(Time.time * frecventa) * aplitudineX / 2;
            if (ySin > 0)
                transform.position = new Vector2(poz.x + xSin - aplitudineX / 2, poz.y + ySin);    
        }
        if (transform.position.y < poz.y)
        {
            jump = false;
            groundcol = false;
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
       
        jump = false;
        groundcol = true;
        poz = new Vector2(transform.position.x, transform.position.y);

    }
}

