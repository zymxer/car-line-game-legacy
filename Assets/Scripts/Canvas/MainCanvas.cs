using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCanvas : MonoBehaviour
{
    public GameObject GameCanvas;
    public GameObject Lines;
    public GameObject StopCar;

    public GameObject ShopCamera;
    public GameObject MainCamera;
    public GameObject ShopCanvas;

    public GameObject SettingsCanvas;

    public GameObject QuestionCanvas;

    public GameObject AchieveCanvas;

    public GameObject Music;

    void Start()
    {
        if (PlayerPrefs.GetInt("MusicChanged") != 0)
        {
            Music.GetComponent<AudioSource>().enabled = (PlayerPrefs.GetInt("MusicEnabled") == 1) ? true : false;
        }    

    }

    public void StartButton()
    {
        PlayerPrefs.SetInt("FirstLaunch", 1);
        SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Single);
    }

    public void ShopButton()
    {
        ShopCamera.SetActive(true);
        MainCamera.SetActive(false);
        ShopCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

    public void SettingsButton()
    {
        SettingsCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

    public void QuestionButton()
    {
        QuestionCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

    public void AchieveButton()
    {
        AchieveCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
