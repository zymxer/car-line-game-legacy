using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
       public Text scoreText, hiscoretext, moneyText, moneyInShopText;
       public float Speed = 0;
       public GameObject ScorePoint;
       int Score = 0, Hight_score;
       public float timer = 0;
       public bool Fly = false;  
       public int Money = 0;
      


    void Start()
    {
		Money = PlayerPrefs.GetInt( "moneyForShop", Money );
		
        Hight_score = PlayerPrefs.GetInt( "MyHight_score", Hight_score );
		
    }






    void FixedUpdate()
    {
	      transform.rotation = GameObject.FindWithTag("body").transform.rotation;
		 
		 transform.position = Vector3.Lerp(transform.position, GameObject.FindWithTag("body").transform.position,  Time.deltaTime *100f);
        hiscoretext.text = "HI-SCORE:" + Hight_score;
        scoreText.text = "SCORE:" + Score;
		 moneyText.text = "Money:" + Money;
		 moneyInShopText.text = "Money:" + Money;
		 Money = PlayerPrefs.GetInt( "moneyForShop", Money );
    }





    void Update()
	{
		if(Fly == true)
		{ 
	     timer += 1* Time.deltaTime;
		  if(timer>1.3)
		    { 
		     //  Money ++;
		    //   Score++;
			   timer = 0;
			  // PlayerPrefs.SetInt( "moneyForShop", Money );
			  
		    }
		}		   
	}






    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "scorePoint")
        {	
             Score+= 10;
             Destroy(col.gameObject, 0f);
			Money +=10;
			PlayerPrefs.SetInt( "moneyForShop", Money );
        
			if(Hight_score < Score)
			{			
			 Hight_score = Score;
		     PlayerPrefs.SetInt( "MyHight_score", Hight_score );
			}   
        }


        if (col.gameObject.tag == "Dead")
        {
			 
            Application.LoadLevel(Application.loadedLevel);
        }
		
		
		if (col.gameObject.tag != "Platform" && col.gameObject.tag != "Line")
        {   	
         	Fly = true;	   
        }
		else
	    {
		 timer = 0;
	     Fly = false;		 
	    }
		
    }









}
