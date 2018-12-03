using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {

    float timeLeft = 300.0f;

    public GUIText text;
    void Update () {
        timeLeft -= Time.deltaTime;
        text.text = "Time Left:" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            
        }
    }
}
