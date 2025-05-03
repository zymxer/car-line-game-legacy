using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitCanvas : MonoBehaviour
{
    public GameObject PauseCanvas;

    public void ExitButton()
    {
        PauseCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
