using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pasue : MonoBehaviour

{
    public GameObject Image;
    public Button button1;
    public static bool isPaused = false ;

      GameObject varGameObject;
      public static bool gameIsPaused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
            
 
  
        }
    }

    public void PauseGame ()
    {
        if(gameIsPaused)
        {
            Time.timeScale = 0f;
             varGameObject = GameObject.FindWithTag("Player"); 
             varGameObject.GetComponent<Fish>().enabled = false;
             Image.SetActive(true);
            // Image.GetComponent<Image>().enabled = true;
           
             
        }
        else 
        {
            Time.timeScale = 1;
             varGameObject = GameObject.FindWithTag("Player"); 
             varGameObject.GetComponent<Fish>().enabled = true;
             Image.SetActive(false);
           
        }
    }
     public void OnButtonPress()
    {
        gameIsPaused = !gameIsPaused;
        PauseGame();
    }

    
    
}
