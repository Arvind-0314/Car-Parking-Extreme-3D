using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class parkController : MonoBehaviour
{
    public GameObject successPanel; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            successPanel.SetActive(true);
            Time.timeScale = 0f; 
        }
    }

    
    public void GoToLevelSelect()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("LevelSelect"); 
    }
}
