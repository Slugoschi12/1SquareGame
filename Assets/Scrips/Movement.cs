using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public bool jump, startGame;
    private Rigidbody2D rb;
    public float distance;
    public float vel, jumpForce;
    float curentPosX;
 
    [SerializeField] Transform castLeft;
    [SerializeField] Transform castRight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = false;
        startGame = false;
        
    }

    void Update()
    {
        
        transform.rotation = Quaternion.Euler(0, 0, 0);
    
        Move();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        curentPosX = transform.position.x;
        jump = false;
         
    }
    
    private bool raycastCheck(Transform obj, int direction)
    {
        RaycastHit2D hit = Physics2D.Raycast(obj.transform.position, transform.right, 2f * direction);

        if (hit.collider != null)
        {
            
            return true;

        }
        else
        {
            
            return false;
        }
    }

    void Move()
    {
        float MaxX = Input.GetAxisRaw("Horizontal");
        if (MaxX == -1 && !jump && raycastCheck(castLeft, -1))
        {
            
            rb.velocity = new Vector2(3.8f * MaxX, 17f);
            jump = true;
            startGame = true;
        }
        else if (MaxX == 1 && !jump && raycastCheck(castRight, 1))
        {
            
            rb.velocity = new Vector2(3.8f * MaxX, 17f);
            jump = true;
            startGame = true;
        }
        else if (MaxX != 0 && !jump)
        {
          
            rb.velocity = new Vector2(3.44f * MaxX, 12f);
            jump = true;
            startGame = true;
        }
        if (transform.position.x - curentPosX >= 1.89f)
        {
            rb.velocity = new Vector2(0, -jumpForce);
            curentPosX = transform.position.x;
        } else if (curentPosX  - transform.position.x >= 1.89f)
        {
            rb.velocity = new Vector2(0, -jumpForce);
            
        }


    }



}
