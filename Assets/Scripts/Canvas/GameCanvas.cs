using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCanvas : MonoBehaviour
{
  
	
	

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
