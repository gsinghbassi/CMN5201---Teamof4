using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{
    
  public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }

    public void ExitGame()
    {
        Debug.Log("Exited Game");
        Application.Quit();
    }

    public void Credits()
    {
       
    }
    
}
