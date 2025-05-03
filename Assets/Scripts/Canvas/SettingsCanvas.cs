using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsCanvas : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject Music;

    public GameObject MusicOnImage;
    public GameObject MusicOffImage;
    public GameObject TimeOnImage;
    public GameObject TimeOffImage;

    public bool Enabled = true;
    public bool TimeEnabled;

    void Start()
    {
        //Enabled = (PlayerPrefs.GetInt("MusicOnBool") == 1) ? true : false;
        if(PlayerPrefs.GetInt("MusicChanged") == 1)
        {
            MusicOnImage.SetActive((PlayerPrefs.GetInt("MusicEnabled") == 1) ? true : false);
            MusicOffImage.SetActive((PlayerPrefs.GetInt("MusicEnabled") == 1) ? false : true);
        }
        TimeOffImage.SetActive((PlayerPrefs.GetInt("SlowTimeEnabled") == 1) ? true : false);
        TimeOnImage.SetActive((PlayerPrefs.GetInt("SlowTimeEnabled") == 1) ? false : true);
    }
    public void ExitButton()
    {
        MainCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

    public void PlayMusicButton()
    {
        PlayerPrefs.SetInt("MusicChanged", 1);
        PlayerPrefs.SetInt("MusicEnabled", 1);
        Music = GameObject.FindWithTag("Music");
        Music.GetComponent<AudioSource>().enabled = true;
    }

    public void MuteMusicButton()
    {
        PlayerPrefs.SetInt("MusicChanged", 1);
        PlayerPrefs.SetInt("MusicEnabled", 0);
        Music = GameObject.FindWithTag("Music");
        Music.GetComponent<AudioSource>().enabled = false;
    }

    public void MusicButton()
    {
        Enabled = (PlayerPrefs.GetInt("MusicOnBool") == 1) ? true : false;
        PlayerPrefs.SetInt("MusicEnabled", (Enabled == true) ? 1 : 0);
        PlayerPrefs.SetInt("MusicChanged", 1);
        Music = GameObject.FindWithTag("Music");
        Music.GetComponent<AudioSource>().enabled = Enabled;
        MusicOffImage.SetActive(!Enabled);
        Enabled = !Enabled;
        PlayerPrefs.SetInt("MusicOnBool", (Enabled == true) ? 1 : 0);
        MusicOnImage.SetActive(!Enabled);
    }

    public void SlowTimeButton()
    {
        TimeEnabled = (PlayerPrefs.GetInt("SlowTimeEnabled") == 0) ? true : false;
        TimeOnImage.SetActive(!TimeEnabled);
        TimeEnabled = !TimeEnabled;
        PlayerPrefs.SetInt("SlowTimeEnabled", (TimeEnabled == false) ? 1 : 0);
        TimeOffImage.SetActive(!TimeEnabled);
    }
}
