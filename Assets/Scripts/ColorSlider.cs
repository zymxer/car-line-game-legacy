using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSlider : MonoBehaviour
{
    public GameObject exampleImage;
    public int colorIndex; //1 - r 2-g 3-b
    public void OnValueChange()
    {
        exampleImage.GetComponent<ColorExample>().SetColor();

        if(colorIndex == 1)
        {
            PlayerPrefs.SetFloat("SliderRGBr", gameObject.GetComponent<Slider>().value);
        }
        if(colorIndex == 2)
        {
            PlayerPrefs.SetFloat("SliderRGBg", gameObject.GetComponent<Slider>().value);
        }
        if (colorIndex == 3)
        {
            PlayerPrefs.SetFloat("SliderRGBb", gameObject.GetComponent<Slider>().value);
        }
    }
}