using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer sr;
    public Movement sGame;
    private Text uiLevelSquare;
    public int levelSquare;
   

    void Start()
    {
        uiLevelSquare = GetComponentInChildren<Text>();
        sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(0.898f, 0.532f + levelSquare * 0.07f, 0.620f);
        
  
    }

    void Update()
    {  
       uiLevelSquare.text = "" + levelSquare; 
       
       
       if (levelSquare == 0)
            Destroy(gameObject);
     
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (sGame.startGame == true && col.gameObject.tag == "MainSquare")
        {
            sr.color = new Color(sr.color.r, sr.color.g - 0.07f, sr.color.b);
            levelSquare--;
            
        }
       
    }


}
