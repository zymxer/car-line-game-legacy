using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorExample : MonoBehaviour
{
    private float rgbR;
    private float rgbG;
    private float rgbB;

    public Slider SliderrgbR;
    public Slider SliderrgbG;
    public Slider SliderrgbB;

    void Start()
    {
        if(!PlayerPrefs.HasKey("SliderRGBr"))
        {
            PlayerPrefs.SetFloat("SliderRGBr", 1f);
            PlayerPrefs.SetFloat("SliderRGBg", 1f);
            PlayerPrefs.SetFloat("SliderRGBb", 1f);
        }

        SliderrgbR.value = PlayerPrefs.GetFloat("SliderRGBr");
        SliderrgbG.value = PlayerPrefs.GetFloat("SliderRGBg");
        SliderrgbB.value = PlayerPrefs.GetFloat("SliderRGBb");
        CalculateRGB();
        SetColor();
    }

    public void CalculateRGB()
    {
        rgbR = 255f * SliderrgbR.value;
        rgbG = 255f * SliderrgbG.value;
        rgbB = 255f * SliderrgbB.value;
    }

    public void SetColor()
    {
        gameObject.GetComponent<Image>().color = new Color(SliderrgbR.value, SliderrgbG.value, SliderrgbB.value, 1f);
    }
}
