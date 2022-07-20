using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameoverscreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Checkpoint()
    {
        GameObject.Find("doll_0").GetComponent<Player>().CheckpointRestart();
        gameObject.SetActive(false);
    }


    public void Restartgame()
    {
        SceneManager.LoadScene("SampleScene");
        G_GameManager.Obj_banjocollection = false;
        G_GameManager.Obj_violincollection = false;
        G_GameManager.Obj_huntersleep = false;
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exited Game");
    }
}
