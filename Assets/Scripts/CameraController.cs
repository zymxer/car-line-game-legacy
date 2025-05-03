using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{



	//  GameObject.FindWithTag("Dot").transform.position;
	[SerializeField]
	GameObject player;
	Vector3 camPos;
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		camPos = transform.position;
		camPos.y = GameObject.FindWithTag("body").transform.position.y;
		transform.position = Vector3.Lerp(transform.position, camPos, Time.deltaTime * 0.75f);
		//Camera.main.size
		GameObject go = (GameObject.FindWithTag("Dot")); // проверка того есть ли точка камеры на сцене
	   
       if (go == null)
		   {
 
           }
		else
        {
			Transform();
		}			
	  
	  
    }
	
	
	
	 void Transform()
	 {
		   transform.position = Vector3.Lerp(transform.position, new Vector3(GameObject.FindWithTag("Dot").transform.position.x, camPos.y, GameObject.FindWithTag("Dot").transform.position.z),  Time.deltaTime *1.5f);
	 }
}
