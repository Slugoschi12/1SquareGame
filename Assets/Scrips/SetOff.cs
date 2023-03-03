using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//activeaza/dezactiveaza death zone
public class SetOff : MonoBehaviour
{
    public void setDeathZone0ff()
    {
        PlayerPrefs.SetInt("deathZoneOff", 1);
    }
    public void setDeathZone0n()
    {
        PlayerPrefs.SetInt("deathZoneOff", 0);
    }
}
