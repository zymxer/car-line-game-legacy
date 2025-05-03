using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetButtonDown : MonoBehaviour
{
    public int ButtonNumber;
    public Sprite[] Sprites = new Sprite[22];

    public void ButtonDown()
    {
        Debug.Log("Down");
        GetComponent<Image>().sprite = Sprites[ButtonNumber];
    }

    public void ButtonUp()
    {
        Debug.Log("UP");
        GetComponent<Image>().sprite = Sprites[ButtonNumber+1];
    }

}
