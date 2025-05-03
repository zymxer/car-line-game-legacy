using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generator2_0 : MonoBehaviour
{
    public GameObject Platform;
    public GameObject CameraDot;
    public GameObject ScorePoint;
    public GameObject TimeTriger;
    public GameObject DeadTriger;
    public GameObject Lines;



    private bool TimerEnabled = true;
    private float Timer = 15f;
    public float XdistMin, XdistMax, YdistMin, YdistMax;
    public float XScoredistMin, XScoredistMax, YScoredistMin, YScoredistMax;
    public float DeadTriggerH;

    public GameObject LoseCanvas;
    public GameObject GameCanvas;

    public GameObject ScoreController;

    public int Passed = 0;

    public Text TimerText;

    public bool AnimPlayed = false;

    public GameObject TextParent;
    public Animator animator;

    void Start()
    {
        animator = TimerText.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if(TimerEnabled == true)
        {
            Timer -= Time.deltaTime;
            if(Timer<=4.1f)
            {
                
                if (AnimPlayed == false)
                {
                    if (Timer <= 0.5f)
                    {
                        TimerText.GetComponent<Text>().text = "FAIL!";
                    }
                    else
                    {
                        TimerText.GetComponent<Text>().text = "" + Mathf.Round(Timer);
                    }
                    
                    TextParent.SetActive(true);

                    if (animator != null)
                    {
                        /*if(animator.GetBool("open") == true)
                        {
                            animator.Play("TextAnim", -1, 0);
                        } */
                        //bool isopen = animator.GetBool("open");
                        animator.SetBool("open", true);
                        animator.SetBool("played", AnimPlayed);
                        // Debug.Log(animator.GetBool("open") + "   fly after set true");
                    }
                }
            }
            if(Timer <= 0f)
            {
                PlayerPrefs.SetInt("DeathAmount", PlayerPrefs.GetInt("DeathAmount") + 1);
                if(ScoreController.GetComponent<ScoreController>().CurrentScore == 0)
                {
                    PlayerPrefs.SetInt("ZeroPointsInARaw", PlayerPrefs.GetInt("ZeroPointsInARaw") + 1);
                }
                if (ScoreController.GetComponent<ScoreController>().CurrentScore != 0)
                {
                    PlayerPrefs.SetInt("ZeroPointsInARaw", 0);
                }
                Timer = 15f;
                Time.timeScale = 0f;
                Lines.GetComponent<LineFactory>().enabled = false;
                GameCanvas.SetActive(false);
                LoseCanvas.SetActive(true);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Passed++;
            if(Passed>=2)
            {
            ScoreController.GetComponent<ScoreController>().CurrentScore+=2;
            ScoreController.GetComponent<ScoreController>().TotalScore += 2;
            }
            TimerEnabled = false;
            Generate();
            animator.Play("Empty", -1, 0);
            animator.SetBool("open", false);
            Destroy(gameObject, 0f);
        }
    }

    void Generate()
    {
        float XDistance = Random.Range(XdistMin, XdistMax);
        float YDistance = Random.Range(YdistMin, YdistMax);

        Vector3 PlatformDistance = new Vector3(XDistance, YDistance, 0);
        Vector3 CurrentPosition = Platform.transform.position;
        Vector3 PlatformPosition = PlatformDistance + CurrentPosition;

        float CameraDotX = PlatformPosition.x - 23f;
        float CameraDotY = CurrentPosition.y + 26.3f;
        Vector3 CameraDotPosition = new Vector3(CameraDotX, CameraDotY, -30);

        float DeadTriggerX = CameraDotX - 7.5f;
        float DeadTriggerY = CameraDotY + DeadTriggerH;
        Vector3 DeadTriggerPosition = new Vector3(DeadTriggerX, DeadTriggerY, 0);

        float XScoreDistance = Random.Range(XScoredistMin, XScoredistMax);
        float YScoreDistance = Random.Range(YScoredistMin, YScoredistMax);
        Vector3 ScoreDistance = new Vector3(XScoreDistance, YScoreDistance, 0);
        Vector3 ScorePosition = ScoreDistance + CurrentPosition;

        Instantiate(Platform, PlatformPosition, Platform.transform.rotation);
        Instantiate(DeadTriger, DeadTriggerPosition, DeadTriger.transform.rotation);
        Instantiate(CameraDot, CameraDotPosition, CameraDot.transform.rotation);
        Instantiate(ScorePoint, ScorePosition, ScorePoint.transform.rotation);

    }
}
