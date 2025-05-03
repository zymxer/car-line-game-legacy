using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
	
	 public GameObject audio;
	 
    public void OptionButton() // кнопка для включения и выключения звука
	 { 
		if(gameObject.GetComponent<Toggle>().isOn == true)
		{
			audio.SetActive(true);
		}
	   else
	   {
		   audio.SetActive(false);
	   }
	
	 }
	 
	 
}
