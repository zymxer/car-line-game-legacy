using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionCanvas : MonoBehaviour
{
    public GameObject MainCanvas;

    public GameObject GameplayPanel;
    public GameObject DeathPanel;
    public GameObject EarningsPanel;
    public GameObject ShopPanel;

    public GameObject GameplayButton;
    public GameObject DeathButton;
    public GameObject EarningsButton;
    public GameObject ShopButton;

    public void ExitButton()
    {
        MainCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

    public void GamePlayButton()
    {
        GameplayButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        DeathButton.GetComponent<Image>().color = new Color32(138, 138, 138, 255);
        EarningsButton.GetComponent<Image>().color = new Color32(138, 138, 138, 255);
        ShopButton.GetComponent<Image>().color = new Color32(138, 138, 138, 255);

        GameplayPanel.SetActive(true);
        DeathPanel.SetActive(false);
        EarningsPanel.SetActive(false);
        ShopPanel.SetActive(false);
    }

    public void DeathButto()
    {
        GameplayButton.GetComponent<Image>().color = new Color32(138, 138, 138, 255);
        DeathButton.GetComponent<Image>().color =  new Color32(255, 255, 255, 255);
        EarningsButton.GetComponent<Image>().color = new Color32(138, 138, 138, 255);
        ShopButton.GetComponent<Image>().color = new Color32(138, 138, 138, 255);

        GameplayPanel.SetActive(false);
        DeathPanel.SetActive(true);
        EarningsPanel.SetActive(false);
        ShopPanel.SetActive(false);
    }

    public void EarnButton()
    {
        GameplayButton.GetComponent<Image>().color = new Color32(138, 138, 138, 255);
        DeathButton.GetComponent<Image>().color = new Color32(138, 138, 138, 255);
        EarningsButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        ShopButton.GetComponent<Image>().color = new Color32(138, 138, 138, 255);

        GameplayPanel.SetActive(false);
        DeathPanel.SetActive(false);
        EarningsPanel.SetActive(true);
        ShopPanel.SetActive(false);
    }

    public void ShopButto()
    {
        GameplayButton.GetComponent<Image>().color = new Color32(138, 138, 138, 255);
        DeathButton.GetComponent<Image>().color = new Color32(138, 138, 138, 255);
        EarningsButton.GetComponent<Image>().color = new Color32(138, 138, 138, 255);
        ShopButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);

        GameplayPanel.SetActive(false);
        DeathPanel.SetActive(false);
        EarningsPanel.SetActive(false);
        ShopPanel.SetActive(true);
    }

}
