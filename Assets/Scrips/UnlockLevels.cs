using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//sistem de deblocat nivelele
public class UnlockLevels : MonoBehaviour
{
    public Button[] levelButtons;

    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        for(int i = 0; i < levelButtons.Length; i++)
        {   
            if(i+1 > levelReached)
                levelButtons[i].interactable = false;
        }
    }
}
