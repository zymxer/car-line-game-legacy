using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PauseCanvas : MonoBehaviour
{
    public GameObject GameCanvas;
    public GameObject QuitCanvas;
    public GameObject Lines;

    public void ExitButton()
    {
        GameCanvas.SetActive(true);
        Lines.GetComponent<LineFactory>().enabled = true;
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitButton()
    {
        QuitCanvas.SetActive(true);
        gameObject.SetActive(false);
    }
}
