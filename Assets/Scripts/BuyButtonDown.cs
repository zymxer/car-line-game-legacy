using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButtonDown : MonoBehaviour
{
    public GameObject SLine;
    public GameObject BLine;

    public void ButtonDown()
    {
        BLine.SetActive(true);
        SLine.SetActive(false);
    }

    public void ButtonUP()
    {
        BLine.SetActive(false);
        SLine.SetActive(true);
    }

}
