using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundStop : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioListener audioListener;


    void Update()
    {
        if(Time.timeScale == 0)
        {
             audioListener.enabled = false;
             audioSource.enabled = false;
        }
        else
        {
           
            audioListener.enabled = true;
            audioSource.enabled = true;

            
        }
        
    }
}
