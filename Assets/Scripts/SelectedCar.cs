using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCar : MonoBehaviour
{
    public GameObject[] CarsArray = new GameObject[5];
    public GameObject Music;
    public GameObject SlowTime;
    void Start()
    {
        Time.timeScale = 1f;
        if(PlayerPrefs.GetInt("SelectedCar") == 0)
        {
            CarsArray[0].SetActive(true);
        }
        else
        {
        CarsArray[PlayerPrefs.GetInt("SelectedCar")-1].SetActive(true);
        }
        SlowTime.SetActive((PlayerPrefs.GetInt("SlowTimeEnabled") == 0) ? true : false);
    }

}
