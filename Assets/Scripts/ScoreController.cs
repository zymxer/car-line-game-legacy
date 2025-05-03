using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int BestScore;
    public int CurrentScore = 0;
    public int TotalScore = 0;

    public Text ScoreText;
    public Text BestScoreText;
    public Text NewRecordText;

    public bool AnimPlayed = false;

    public GameObject TextParent;

    float Timer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        BestScore = PlayerPrefs.GetInt("BestScore", BestScore);
        TotalScore = PlayerPrefs.GetInt("TotalScore", TotalScore);
        if (PlayerPrefs.GetInt("FirstLaunch") == 0)
        {
            BestScore = 0;
            TotalScore = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(CurrentScore > BestScore && AnimPlayed == false && BestScore!= 0)
        {
            TextParent.SetActive(true);
            Animator animator = NewRecordText.GetComponent<Animator>();
            AnimPlayed = NewRecordText.GetComponent<TextBool>().AnimPlayed;
            if (animator != null)
            {
                //bool isopen = animator.GetBool("open");
                animator.SetBool("open", true);
                animator.SetBool("played", AnimPlayed);
                
            }
        }
        if(AnimPlayed == true)
        {
            Timer -= Time.deltaTime;
            if(Timer <= 0f)
            {
                TextParent.SetActive(false);
            }
        }
        PlayerPrefs.SetInt("TotalScore", TotalScore);
        ScoreText.text = CurrentScore + "";
        BestScoreText.text = "BEST SCORE: " + PlayerPrefs.GetInt("BestScore", BestScore);
    }
}
