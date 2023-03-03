using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UILevel : MonoBehaviour
{
    public int levelIndex;
    private Text uiLevelSquare;

     void Start()
    {  levelIndex = SceneManager.GetActiveScene().buildIndex;
        uiLevelSquare = GetComponentInChildren<Text>();
       
    }
    private void Update()
    {
        uiLevelSquare.text = " Level " + levelIndex;

    }
}
