using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTSOnRotate : MonoBehaviour
{
    public GameObject Player;
    public GameObject MoneyController;
    float Amount = 1;        
    float Circle = 360;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        MoneyController = GameObject.FindWithTag("MoneyController");
    }

    // Update is called once per frame
    void Update()
    {
        float Rotation1 = Player.GetComponent<Rigidbody2D>().rotation;
        float Rotation2 = 0f;

        if(Mathf.Abs(Rotation1)>=Circle)
        {
            MoneyController.GetComponent<AddMoney>().Money += 10;
            Amount++;
            Circle *= Amount;
        }
    }
}
