using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadOnTrigger : MonoBehaviour
{
    public GameObject LoseCanvas;
    public GameObject GameCanvas;
    public GameObject ScoreController;
    public GameObject Lines;

    void Start()
    {
        ScoreController = GameObject.FindWithTag("ScoreController");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Dead")
        {
            PlayerPrefs.SetInt("DeathAmount", PlayerPrefs.GetInt("DeathAmount") + 1);
            if (ScoreController.GetComponent<ScoreController>().CurrentScore == 0)
            {
                PlayerPrefs.SetInt("ZeroPointsInARaw", PlayerPrefs.GetInt("ZeroPointsInARaw") + 1);
            }
            if(ScoreController.GetComponent<ScoreController>().CurrentScore != 0)
            {
                PlayerPrefs.SetInt("ZeroPointsInARaw", 0);
            }
            Lines.GetComponent<LineFactory>().enabled = false;
            Time.timeScale = 0f;
            GameCanvas.SetActive(false);
            LoseCanvas.SetActive(true);
        }
    }
}
