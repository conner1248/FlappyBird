using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{
    [SerializeField]
    public static float speed = 3f;

    [SerializeField]
    float RandomOffset = 2f;

    private float loc = 15f;

    

    


    void awake()   
    {
         GameObject thePlayer = GameObject.Find("Player");
        Fish playerScript = thePlayer.GetComponent<Fish>();
        
       // Debug.Log("Fish.score: " + Fish.score);

    }

  
  

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * speed * Vector3.left;
      
       
           
       
       
         
        if(transform.position.x <= -15)
        {
            if(RandomOffset == 0)
            {
                transform.position = new Vector3(loc,transform.position.y,transform.position.z);

            }
            else
            {
                
            
            float randomHeight = Random.Range(-RandomOffset, RandomOffset);
            transform.position = new Vector3(loc,randomHeight,transform.position.z);
             if(Fish.score % 15 == 0f)
            {

                loc +=1f; 
            }
            }
            
        }
       
        
        
    }
    
        
    
   
}
