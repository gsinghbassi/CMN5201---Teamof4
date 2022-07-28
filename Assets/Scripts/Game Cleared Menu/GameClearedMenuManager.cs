using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearedMenuManager : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitGame()
    {
        Debug.Log("Exited Game");
        Application.Quit();
    }

    public void BacktoStartMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }



}
