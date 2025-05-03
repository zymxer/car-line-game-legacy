using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TimeSlowEffect : MonoBehaviour
{
    public GameObject gameVolume;
    public GameObject timeVolume;
    private bool gameMode = true;

    public void ChangeEffect()
    {
        if(gameMode)
        {
            gameVolume.SetActive(false);
            timeVolume.SetActive(true);
            gameMode = false;
            return;
        }

        if(gameMode == false)
        {
            gameVolume.SetActive(true);
            timeVolume.SetActive(false);
            gameMode = true;
            return;
        }
    }

}
