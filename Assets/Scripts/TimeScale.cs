using System;
using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class TimeScale : MonoBehaviour
{
 

    // Update is called once per frame
    void FixedUpdate()
    {
		
       /*  if (Input.GetKey(KeyCode.Space))
            {
               Time.timeScale = 0.1f;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
            }
         else
            {
                Time.timeScale = 1;
            } */
			
	}
	
	public void ButtonDown()
    {
		 Time.timeScale = 0.1f;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
   
			
	}
	
	public void ButtonUp()
    {
		 Time.timeScale = 1;
       
   
			
	}
	
}
