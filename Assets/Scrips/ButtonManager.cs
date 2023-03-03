using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] buttons;
    public GameObject menuButton;
    public void EnableMenuButtons()
    {
        StartCoroutine(Enum());
    }
    private IEnumerator Enum ()
    {
        yield return new WaitForSeconds(0.65f);
        menuButton.SetActive(false);
        foreach (GameObject button in buttons)
        {
            button.SetActive(true);
        }
    }
   
}
