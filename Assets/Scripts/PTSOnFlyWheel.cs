using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTSOnFlyWheel : MonoBehaviour
{
    public bool Flying;
    public float Force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag != "Player")
        {
            Flying = true;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != "Player")
        {
            Flying = false;
        }
        if(other.gameObject.tag == "Line")
        {
            GetComponent<ConstantForce2D>().force = new Vector2(0f, 0f);
        }
        else
        {
            GetComponent<ConstantForce2D>().force = new Vector2(Force,0f);
        }
    }
}
