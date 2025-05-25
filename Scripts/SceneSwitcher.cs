using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
     public void level1()
    {
        SceneManager.LoadScene("Level-1");
    }
    public void level2()
    {
        SceneManager.LoadScene("Level-2");
    }
    public void level3()
    {
        SceneManager.LoadScene("Level-3");
    }
    public void levelChoose()
    {
        SceneManager.LoadScene("levelChoose");
    }
    public void homeScreen()
    {
        SceneManager.LoadScene("entry");
    }
}