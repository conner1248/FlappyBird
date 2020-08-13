using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeeWeed : MonoBehaviour
{
    public AudioSource die;
    public GameObject gameoverUI;
    public float restartDelay = .02f;

    void awake()
    {
        GameObject the2 = GameObject.Find("Player");
        Fish script = the2.GetComponent<Fish>();
          GameObject the1 = GameObject.Find("ground");
           ground script1 = the1.GetComponent<ground>();
           GameObject the = GameObject.Find("Enemy");
     Move Script = the.GetComponent<Move>();
         GameObject the3 = GameObject.Find("MainCamera");
     pasue script2 = the3.GetComponent<pasue>();
     
     
    }
  
   
     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            die.Play();

            pasue.isPaused = true;


            gameoverUI.SetActive(true);
             
            Time.timeScale  = 0f;
           

         
        }
        else
        {
            pasue.isPaused = false;
            gameoverUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
     public void Restart()
    {
        
        
        
        Debug.Log("Restart Function called");
       Time.timeScale = 1;
         Fish.score = 0; 
            ground.scrollSpeed = 1.45f;
            Move.speed = 3f;
           
            
            Debug.Log("Score Resetted : " + Fish.score + " " + ground.scrollSpeed + " " + Move.speed);
           
           SceneManager.LoadScene(2);
         
    }
    

}
