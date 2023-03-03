using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Animator tranzition;
    public void LoadLevel(int levelIndex)
    {   
        StartCoroutine(Wait(levelIndex));  
    }
   private IEnumerator Wait(int levelId)
    {
        yield return new WaitForSeconds(0.65f);
        tranzition.SetTrigger("Start");
        yield return new WaitForSeconds(0.65f);
        SceneManager.LoadScene(levelId);
    }
}
