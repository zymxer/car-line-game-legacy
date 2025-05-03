using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TimeStop : MonoBehaviour
{
    // Start is called before the first frame update
    void FixedUpdate()
    {
        if (!ispressed)
            return;
        Time.timeScale = 0.1f;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
    bool ispressed = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
        Time.timeScale = 1;
    }
}
