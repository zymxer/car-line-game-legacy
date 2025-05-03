using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PTSOnFlyBody : MonoBehaviour
{
    public GameObject Wheel1;
    public GameObject Wheel2;
    public GameObject MoneyController;
    public GameObject AchievesController;
    private bool Wheel1ST;
    private bool Wheel2ST;
    private bool Flying;
    public float Timer = 0;

    public Text FlipText;

    public bool AnimPlayed = false;

    public GameObject TextParent;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = FlipText.GetComponent<Animator>();
        MoneyController = GameObject.FindWithTag("MoneyController");
        AchievesController = GameObject.FindWithTag("AchievesController");
    }
    void FixedUpdate()
    {
        Wheel1ST = Wheel1.GetComponent<PTSOnFlyWheel>().Flying;
        Wheel2ST = Wheel2.GetComponent<PTSOnFlyWheel>().Flying;

        if (Flying == true && Wheel1ST == true && Wheel2ST == true)
        {
            Timer+=Time.deltaTime;
            Wheel1.GetComponent<ConstantForce2D>().force = new Vector2(0f, 0f);
            Wheel2.GetComponent<ConstantForce2D>().force = new Vector2(0f, 0f);
        }
        if (Flying == false || Wheel1ST == false || Wheel2ST == false)
        {
            if(Timer >= 1f)
            {
                PlayerPrefs.SetInt("TimeInFly", (int)Mathf.Round(Timer));
                Timer = Mathf.Round(Timer) * 10;
                MoneyController.GetComponent<AddMoney>().Money += (int)Timer;
                MoneyController.GetComponent<AddMoney>().TotalMoney += (int)Timer;
                //Debug.Log(animator.GetBool("open") + "   fly after land");
                if (AnimPlayed == false)
                {
                    
                    FlipText.GetComponent<Text>().text = "x" + Timer / 10 + " air time!"; 
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
            Timer = 0f;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag != "Wheel")
        {
            Flying = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != "Wheel")
        {
            Flying = false;
        }
    }
}
