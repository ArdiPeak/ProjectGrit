using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu; // PascalCase for class name, camelCase for variables
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Home()
    {
        SceneManager.LoadScene("main menu");
        Time.timeScale = 1;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextStage1()
    {
        SceneManager.LoadScene("stage1");
        Time.timeScale = 1;
    }
    public void NextStage2()
    {
        SceneManager.LoadScene("stage2");
        Time.timeScale = 1;
    }
    public void Cutscene()
    {
        SceneManager.LoadScene("Cutscene");
        Time.timeScale = 1;
    }
    public void Endscene()
    {
        SceneManager.LoadScene("Endscene");
        Time.timeScale = 1;
    }
}
