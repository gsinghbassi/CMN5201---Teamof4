using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_NPC : MonoBehaviour
{
    public int activetext;
    public int objectivecompleteTextnumber;
    public bool objectivecompleted;
    public GameObject Reward;
    public GameObject SideQuestObjectiveItem;
    public string SideQuestObjectiveItemname;
    [TextArea (5,10)]
    public string[] DialogueNPC;
    public string[] ButtonText;
    
    



    // Start is called before the first frame update
    void Start()
    {
        Reward.gameObject.SetActive(false);
        activetext = 0;
        objectivecompleted = false;
        SideQuestObjectiveItemname = SideQuestObjectiveItem.name;
        SideQuestObjectiveItem.SetActive(false);
    }

   public void UpdateActiveText()
    {
        if(!objectivecompleted)
        {
            activetext = 1;
            G_GameManager.begin_sidequests = true;
            SideQuestObjectiveItem.SetActive(true);
        }

        if(objectivecompleted && activetext < DialogueNPC.Length-1)
        {
            if (activetext == objectivecompleteTextnumber)
            {
                Reward.gameObject.SetActive(true);
            }

            activetext++;
        }

    }    

    



}
