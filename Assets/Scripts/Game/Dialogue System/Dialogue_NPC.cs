using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_NPC : MonoBehaviour
{
    public int activetext;
    public int objectivecompleteTextnumber;
    public bool objectivecompleted;
    public string ItemName;
    public int reward;
    [TextArea (5,10)]
    public string[] DialogueNPC;
    public string[] ButtonText;
    
    // Start is called before the first frame update
    void Start()
    {
        activetext = 0;
        objectivecompleted = false;
    }

   public void UpdateActiveText()
    {
        if(!objectivecompleted)
        {
            activetext = 1;
        }

        if(objectivecompleted && activetext < DialogueNPC.Length-1)
        { 
            activetext++;
        }

    }    



}
