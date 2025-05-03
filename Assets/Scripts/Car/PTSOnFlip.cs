using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PTSOnFlip : MonoBehaviour
{
    public GameObject Player;
    public GameObject MoneyController;
    public GameObject ScoreController;
    public GameObject AchievesController;
    public float Rotation;
    public float PreviousRotation = 0;
    public float RotationDiff = 0;

    public Text FlipText;

    public bool AnimPlayed = false;

    public GameObject TextParent;
    public Animator animator;

    float Timer = 4f;
    // Start is called before the first frame update
    void Start()
    {
        animator = FlipText.GetComponent<Animator>();
        ScoreController = GameObject.FindWithTag("ScoreController");
        Player = GameObject.FindWithTag("Player");
        MoneyController = GameObject.FindWithTag("MoneyController");
        AchievesController = GameObject.FindWithTag("AchievesController");
    }

    void FixedUpdate()
    {

        Rotation = Player.GetComponent<Rigidbody2D>().rotation;
        RotationDiff += Rotation - PreviousRotation;
        PreviousRotation = Rotation;
        if (RotationDiff <= -340f || RotationDiff >= 340f)
        {
            if(RotationDiff <= -340f)
            {
                RotationDiff = -360f - RotationDiff;
            }
            else
            {
                RotationDiff = 360f - RotationDiff;
            }
            //RotationDiff = 0f;
            MoneyController.GetComponent<AddMoney>().Money += 10;
            MoneyController.GetComponent<AddMoney>().TotalMoney += 10;
            ScoreController.GetComponent<ScoreController>().CurrentScore += 10;
            ScoreController.GetComponent<ScoreController>().TotalScore += 10;

            AchievesController.GetComponent<AchievesController>().FlipsAmount++;
            PlayerPrefs.SetInt("FlipsAmount",AchievesController.GetComponent<AchievesController>().FlipsAmount);

              if (AnimPlayed == false)
              {

                  TextParent.SetActive(true);
                  
                  if (animator != null)
                  {
                    if(animator.GetBool("open") == true)
                    {
                        animator.Play("TextAnim", -1, 0);
                        animator.SetBool("open", false);
                    } 
                      //bool isopen = animator.GetBool("open");
                      animator.SetBool("open", true);
                      animator.SetBool("played", AnimPlayed);
                  }
              }           
          }
            
        }

    public void ChangeParameter()
    {
        animator = FlipText.GetComponent<Animator>();
        animator.SetBool("open", false);
    }
}