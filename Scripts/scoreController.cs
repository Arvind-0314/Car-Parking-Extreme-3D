using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timerText;// Assign your TextMeshProUGUI object in the inspector
    public float timeTaken;           // Set from your timer
    public int crashCount;            // Update this on each crash

    public int totalScore = 100;
    public int crashPenalty = 10;
    public int timePenalty1 = 20; // after 20 seconds
    public int timePenalty2 = 10; // after 40 seconds

    private bool penalty20Applied = false;
    private bool penalty40Applied = false;

    void Update()
    {
        timeTaken += Time.deltaTime;

        // Apply -20 after 20 seconds (only once)
        if (timeTaken > 20f && !penalty20Applied)
        {
            totalScore -= timePenalty1;
            penalty20Applied = true;
        }

        // Apply -10 after 40 seconds (only once)
        if (timeTaken > 40f && !penalty40Applied)
        {
            totalScore -= timePenalty2;
            penalty40Applied = true;
        }

        UpdateScoreUI();
    }

    public void RegisterCrash()
    {
        totalScore -= crashPenalty;
        crashCount++;
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + Mathf.Max(totalScore, 0).ToString();
        }
    }

    public void ShowFinalScore()
    {
        UpdateScoreUI(); // Optionally call this when level ends
        // You can add any animations, sound, or level-complete triggers here
    }
}
