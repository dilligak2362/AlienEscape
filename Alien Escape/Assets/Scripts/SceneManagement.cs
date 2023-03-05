using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void RestartLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void RestartLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void RestartLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void RestartLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ExitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
}
