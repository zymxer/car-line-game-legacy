using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineColorSetter : MonoBehaviour
{
    public Gradient lineGradient;
    private Color color;
    private GradientColorKey[] colorKey;
    private GradientAlphaKey[] alphaKey;
    public GameObject Lines;

    void Start()
    {
        color = new Color(PlayerPrefs.GetFloat("SliderRGBr"), PlayerPrefs.GetFloat("SliderRGBg"), PlayerPrefs.GetFloat("SliderRGBb"), 1f);
        lineGradient = new Gradient();
        SetGradient();
        SetLineColor();
    }

    public void SetGradient()
    {
        colorKey = new GradientColorKey[2];
        colorKey[0].color = color;
        colorKey[0].time = 0.0f;
        colorKey[1].color = color;
        colorKey[1].time = 1.0f;

        alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 1f;
        alphaKey[1].time = 1.0f;

        lineGradient.SetKeys(colorKey, alphaKey);
    }

    public void SetLineColor()
    {
        Lines.GetComponent<LineFactory>().linePrefab.GetComponent<LineRenderer>().colorGradient = lineGradient;
    }
}