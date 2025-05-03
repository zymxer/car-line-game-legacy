using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseCanvas : MonoBehaviour
{
    public GameObject ScoreController;

    public void RestartButton()
    {
        if (ScoreController.GetComponent<ScoreController>().CurrentScore > ScoreController.GetComponent<ScoreController>().BestScore)
        {
            PlayerPrefs.SetInt("BestScore", ScoreController.GetComponent<ScoreController>().CurrentScore);
        }
        ScoreController.GetComponent<ScoreController>().CurrentScore = 0;
        //Time.timeScale = 1f;
        SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Single);
    }
    public void MainMenuButton()
    {
        if (ScoreController.GetComponent<ScoreController>().CurrentScore > ScoreController.GetComponent<ScoreController>().BestScore)
        {
            PlayerPrefs.SetInt("BestScore", ScoreController.GetComponent<ScoreController>().CurrentScore);
        }
        ScoreController.GetComponent<ScoreController>().CurrentScore = 0;
        //Time.timeScale = 1f;
        SceneManager.LoadSceneAsync("MainMenu", LoadSceneMode.Single);
    }
}
