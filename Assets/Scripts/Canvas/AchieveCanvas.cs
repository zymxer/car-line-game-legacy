using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchieveCanvas : MonoBehaviour
{
    public GameObject MainCanvas;

    public void ExitButton()
    {
        MainCanvas.SetActive(true);
        gameObject.SetActive(false);
    }
}
