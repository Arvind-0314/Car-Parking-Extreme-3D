using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class timeController : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeRemaining = 60f;
    public bool timerRunning = true;

    void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;

                int minutes = Mathf.FloorToInt(timeRemaining / 60);
                int seconds = Mathf.FloorToInt(timeRemaining % 60);
                timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
            else
            {
                timeRemaining = 0;
                timerRunning = false;
                RestartScene();
            }
        }
    }

    public void StopTimer()
    {
        timerRunning = false;
    }

    public float GetTime()
    {
        return timeRemaining;
    }

    void RestartScene()
    {
        Time.timeScale = 1f; // Just in case it was paused
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

