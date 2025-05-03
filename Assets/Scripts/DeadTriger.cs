using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadTriger : MonoBehaviour
{ 
    

    
    void Start()
    {
       
    
        transform.localScale -= new Vector3(30f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
