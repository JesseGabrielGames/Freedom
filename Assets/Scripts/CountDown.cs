using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{

    public float timeLeft = 300.0f;

    Text text;
    void Awake()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "time Left:" + timeLeft;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
