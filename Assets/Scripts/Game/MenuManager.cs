using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool isPaused;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                isPaused = true;
                PauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void ResumeGame()
    {
        isPaused = false;
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Debug.Log("Exited Game");
        Application.Quit();
    }
}
