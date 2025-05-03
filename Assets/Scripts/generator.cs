using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    public GameObject Platform;
    public GameObject CameraDot;  
    public GameObject ScorePoint;
    public GameObject TimeTriger;
    public GameObject DeadTriger;
  
    void Start()
    {
       
    }


      void OnTriggerEnter2D(Collider2D col)
    { 
     if (col.gameObject.tag=="Player") 
       {
            Generate();
            Debug.Log("Text: "); 
            Destroy(gameObject, 0f);
       }
    }


    void Generate()
    {
        float x = Random.Range(30.0f, 40.0f);
        float y = Random.Range(-6.0f, 9.0f);
		float a, b;
		float DeadTrigerY;
		
		
		if(y >0)
		{
            DeadTrigerY = y-10;     // -5
			a= y *2;
            b = Random.Range(y+ (y / 2f +3f), y+ (y / 3f + 5f));			
		}
		else
		{
			DeadTrigerY = y-10;
			a = -y / 1.6f;
			b = Random.Range(y + (-y *1.2f +3f), y+ (-y * 1.5f + 5f));	
		}

        Vector3 thePosition = transform.TransformPoint(x, y, 0);
        Instantiate(Platform, thePosition, Platform.transform.rotation);

        Vector3 DotPosition = transform.TransformPoint(x/2.2f , a, -10);
        Instantiate(CameraDot, DotPosition, CameraDot.transform.rotation);
		
		Vector3 ScorePointPosition = transform.TransformPoint(x/2, b, 0);
        Instantiate(ScorePoint, ScorePointPosition, ScorePoint.transform.rotation);

        Vector3 DeadTrigerPosition = transform.TransformPoint(x/2, DeadTrigerY, 0);
        DeadTriger.transform.localScale = new Vector3(x, 1f, 0.0f);
        Instantiate(DeadTriger, DeadTrigerPosition, DeadTriger.transform.rotation);
    }
}
