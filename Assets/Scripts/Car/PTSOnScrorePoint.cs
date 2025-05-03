using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTSOnScrorePoint : MonoBehaviour
{
    public GameObject MoneyController;
    public GameObject ScoreController;
    // Start is called before the first frame update
    void Start()
    {
        ScoreController = GameObject.FindWithTag("ScoreController");
        MoneyController = GameObject.FindWithTag("MoneyController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "scorePoint")
        {
            ScoreController.GetComponent<ScoreController>().CurrentScore += 5;
            ScoreController.GetComponent<ScoreController>().TotalScore += 5;
            MoneyController.GetComponent<AddMoney>().Money += 10;
            MoneyController.GetComponent<AddMoney>().TotalMoney += 10;
            other.gameObject.GetComponent<CoinAnimator>().StartAnimation();
        }
    }
}
