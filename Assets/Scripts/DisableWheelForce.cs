using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableWheelForce : MonoBehaviour
{
    public float Force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Line")
        {
            GetComponent<ConstantForce2D>().force.Set(0f, 0f);
        }
    }
}
