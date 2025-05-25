using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class parkingTrigger : MonoBehaviour
{
    public GameObject successPanel;               // Assign your UI panel in the inspector
    public TextMeshProUGUI successText;           // Assign TextMeshPro text (for message)
    public TextMeshProUGUI scoreText;             // Assign TextMeshPro text (for score)
    public int currentScore = 100;                // Set this from your scoring logic
    public float delayBeforeLoad = 2f;            // Time before returning to home

    private bool isParked = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isParked && collision.gameObject.CompareTag("parking"))
        {
            isParked = true;
            successPanel.SetActive(true);
            successText.text = "Success!";
            scoreText.text = "Your Score: " + currentScore.ToString();
            StartCoroutine(ReturnToHomeAfterDelay());
        }
    }

    IEnumerator ReturnToHomeAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeLoad);
        SceneManager.LoadScene("levelChoose"); // Replace with your actual scene name
    }
}
