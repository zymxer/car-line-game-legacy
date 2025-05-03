using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
       
	   void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Line" || col.gameObject.tag == "Platform"  )
        {			
           Application.LoadLevel(Application.loadedLevel);
        }
	}
	
}
