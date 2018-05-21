using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;

    public void play()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void quit()
    {
        Application.Quit();
    }

    public void menu()
    {
        SceneManager.LoadScene("Initial Screen");
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void pause()
    {
        if (isPaused == false)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
        }

    }
}
