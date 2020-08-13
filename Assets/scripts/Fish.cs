using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fish : MonoBehaviour
{
    public float JumpForce = 500f;
    private Rigidbody2D rb;

    public static int score = 0;
    public static bool highscorebeat = false;

     
    public Text scoreText;

    public Animator anim;

    public static int HighScore ;
    public Text HighScoreText;
    

    public AudioSource jump;
    public AudioSource point;





    // Start is called before the first frame update
    void Start()
    {
          HighScoreText.text = PlayerPrefs.GetInt ("HighScore", 0).ToString();

        rb = GetComponent<Rigidbody2D>(); 

       


        anim = GetComponent<Animator>();

        

    
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            reset();
        }




        if(Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
           Jump();
        
        } 
        else
        {
            anim.SetBool("Jump" , false);
        }    
       
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            
            score++;
            point.Play();
            


            Debug.Log("Score:"+ score);
            scoreText.text =  score.ToString();
            if(score > HighScore)
            {
                HighScore = score;
                
            }

            if(score >  PlayerPrefs.GetInt ("HighScore", 0) )
            {
                HighScoreText.text = HighScore.ToString();

                
              
                PlayerPrefs.SetInt("HighScore", HighScore);
                highscorebeat = true ;
            }
     
    }}
      void reset()
        {
            PlayerPrefs.DeleteKey("HighScore");
            HighScoreText.text = "0";
        }
     public void quit()
    {
         Application.Quit();
    }
    public void Jump()
    {
         jump.Play();
            
            rb.velocity = Vector2.zero;
            rb.AddForce( Vector2.up * JumpForce);
            anim.SetBool("Jump" , true);

    }

}
