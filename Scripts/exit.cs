using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quit Game"); // This will show in the editor
        Application.Quit();     // This will close the game in a build
    }
}
