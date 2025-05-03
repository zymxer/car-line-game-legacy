using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddMoney : MonoBehaviour
{
    public int Money;
    public int TotalMoney;
    public Text MoneyText;
    // Start is called before the first frame update
    void Start()
    {
        TotalMoney = PlayerPrefs.GetInt("TotalMoney", TotalMoney);
        Money = PlayerPrefs.GetInt("moneyForShop", Money);
        if (PlayerPrefs.GetInt("FirstLaunch") == 0)
        {
            TotalMoney = 0;
            Money = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerPrefs.SetInt("moneyForShop", Money);
        PlayerPrefs.SetInt("TotalMoney", TotalMoney);
        MoneyText.text = Money + "";
    }
}
