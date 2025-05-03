using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    void Awake ()
    {
        GameObject[] Musics = GameObject.FindGameObjectsWithTag("Music");
        if(Musics.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        if(PlayerPrefs.GetInt("MusicChanged") == 0)
        {
            GetComponent<AudioSource>().enabled = true;
        }
    }
}
