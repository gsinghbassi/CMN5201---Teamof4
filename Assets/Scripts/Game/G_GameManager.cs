using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class G_GameManager : MonoBehaviour
{
    //Objective Management
    public Image Objective1;
    public Image Objective2;
    public Image Objective3;
    public static bool Obj_meetZita;
    public static bool Obj_violincollection;
    public static bool Obj_huntersleep;

    //SideQuest Management
    public static bool begin_sidequests;
    GameObject Canvas_SideQuests;
    public Image SideQuestObjective1;
    public static bool SQObj_GetKeys;







    // Start is called before the first frame update
    void Start()
    {
        Canvas_SideQuests = GameObject.Find("SideObjectives_Panel");
        begin_sidequests = false;
        Obj_meetZita = false;
        Obj_violincollection = false;
        Obj_huntersleep = false;

        Objective1.enabled = false;
        Objective2.enabled = false;
        Objective3.enabled = false;
        Canvas_SideQuests.SetActive(false);
        SideQuestObjective1.enabled = false;
        SQObj_GetKeys = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (begin_sidequests)
        {
            Canvas_SideQuests.SetActive(true);
            begin_sidequests = false;
        }

        if(Obj_meetZita)
        {
            Objective1.enabled = true;
        } 

        if(Obj_violincollection)
        {
            Objective2.enabled = true;

        }
        if(Obj_huntersleep)
        {
            Objective3.enabled = true;

        }
        if(SQObj_GetKeys)
        {
            SideQuestObjective1.enabled = true;
        }
        

    }

    public void Initialize()
    {
        
    }

}
