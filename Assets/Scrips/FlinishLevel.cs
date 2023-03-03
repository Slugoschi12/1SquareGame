using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FlinishLevel : MonoBehaviour
{   
    public LevelManager levelManager;
    public string tagObj;
    public int levelIndex;
    private SpriteRenderer sr;
    private ParticleSystem deathAnim;
    public AudioClip soundDeath;
    public AudioSource audioSrc;
    public AudioClip finishLvl;

   private bool play = true;

    private void Start()
    {
        levelIndex = SceneManager.GetActiveScene().buildIndex;
        sr = GetComponent<SpriteRenderer>();
        deathAnim = GetComponentInChildren<ParticleSystem>();


    }
    void Update()
    {
        finishLevel(tagObj);
    }
    private void finishLevel(string tag)
    {
        if(GameObject.FindGameObjectsWithTag(tag).Length == 0)
        {   if (levelIndex == 6)
                levelManager.LoadLevel(7);
            else
            {   if (play)
                {   play = false; 
                    audioSrc.PlayOneShot(finishLvl); 
                }

                levelManager.LoadLevel(levelIndex + 1);
                PlayerPrefs.SetInt("levelReached", levelIndex + 1);
            }    
        }
       


    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "DeathZone")
        {
            transform.position = new Vector2(transform.position.x, transform.position.y);
            sr.enabled = false;
            sound(soundDeath);
            deathAnim.Play();
            levelManager.LoadLevel(levelIndex);
         
        }
  
    
    }
    public void sound(AudioClip sound)
    {
        audioSrc.PlayOneShot(sound);
    }



}
