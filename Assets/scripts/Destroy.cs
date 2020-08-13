using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    
    public GameObject HighScoreBeat;


    void awake()
    {
        GameObject the = GameObject.Find("beat");
        Fish script = the.GetComponent<Fish>();
    
    


    }

    void update()
    {
        
            
                if(Fish.highscorebeat == true )
            {
                HighScoreBeat.SetActive(true);
               
                Destroy (HighScoreBeat, 2f); 
                
               
        
    }

    }
   



}

