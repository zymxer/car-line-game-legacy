using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelInLine : MonoBehaviour
{
    public GameObject Wheel;
    public GameObject Point;

    [HideInInspector]
    public float WheelX;
    [HideInInspector]
    public float WheelY;

    [HideInInspector]
    public float PointX;
    [HideInInspector]
    public float PointY;

    void FixedUpdate()
    {

        WheelX = Wheel.GetComponent<Rigidbody2D>().position.x;
        WheelY = Wheel.GetComponent<Rigidbody2D>().position.y;
        PointX = Point.transform.position.x;
        PointY = Point.transform.position.y;

        if (Mathf.Sqrt((WheelX-PointX) * (WheelX - PointX) + (WheelY-PointY) * (WheelY-PointY)) > 0.55)
        {
            Wheel.GetComponent<CircleCollider2D>().enabled = false;
        }
        else
        {
            Wheel.GetComponent<CircleCollider2D>().enabled = true;
        }
    }

    // Update is called once per frame

}
