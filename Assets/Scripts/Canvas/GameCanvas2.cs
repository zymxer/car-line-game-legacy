using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GameCanvas2 : MonoBehaviour
{
    public GameObject PauseCanvas;
    public GameObject Lines;
    public bool Pressed = false;
    [SerializeField]
    private PostProcessVolume postProcessing;
    public AudioSource timeSlowAudio;

    public void PauseButton()
    {
        Destroy(Lines.transform.GetChild(Lines.transform.childCount - 1).gameObject);
        PauseCanvas.SetActive(true);
        Lines.GetComponent<LineFactory>().enabled = false;
        gameObject.SetActive(false);
        Time.timeScale = 0f;
    }

    public void ButtonDown()
    {
        Time.timeScale = 0.1f;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }

    public void ButtonUp()
    {
        Time.timeScale = 1;
    }

    public void SlowTimeButton()
    {
        Destroy(Lines.transform.GetChild(Lines.transform.childCount - 1).gameObject);
        if(Pressed == false)
        {
            timeSlowAudio.Play();
            Time.timeScale = 0.1f;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }
        if(Pressed == true)
        {
            Time.timeScale = 1;
        }
        Pressed = !Pressed;
    }

    private void SlowTimeEffect()
    {

    }
    private void NormalEffect()
    {

    }

}
