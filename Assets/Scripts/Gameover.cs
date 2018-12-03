using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour {

    public GameObject gameOverPanel;
    public Text gameOverText;
    float timeLeft = 30.0f;
    public Text text;
    void Awake()
    {
        gameOverPanel.SetActive(false);
    }
    void GameOver()
    {
        
        gameOverPanel.SetActive(true);
        gameOverText.text = "Game Over";
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "Time Left:" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            GameOver();
        }
    }
}
