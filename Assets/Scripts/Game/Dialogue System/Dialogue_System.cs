using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue_System : MonoBehaviour
{
    public GameObject DialogueCanvas;
    public Text DialogueTextUI;
    public Text ButtonTextUI;
    Dialogue_NPC NPCController;



    // Start is called before the first frame update
    void Start()
    {

       
        DialogueTextUI = DialogueCanvas.transform.Find("DialogueText").GetComponent<Text>();
        ButtonTextUI= DialogueCanvas.transform.Find("Button").transform.Find("ButtonText").GetComponent<Text>();
        DialogueCanvas.SetActive(false);
    }

  public void UpdateText(GameObject NPC)
    {
        NPCController = NPC.GetComponent<Dialogue_NPC>();
        DialogueTextUI.text = NPCController.DialogueNPC[NPCController.activetext];
        ButtonTextUI.text = NPCController.ButtonText[NPCController.activetext];
       

    }


   
}
