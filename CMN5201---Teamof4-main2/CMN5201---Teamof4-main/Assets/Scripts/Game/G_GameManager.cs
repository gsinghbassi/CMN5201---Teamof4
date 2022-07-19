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
    public static bool Obj_banjocollection;
    public static bool Obj_violincollection;
    public static bool Obj_huntersleep;

   





    // Start is called before the first frame update
    void Start()
    {
        Objective1.enabled = false;
        Objective2.enabled = false;
        Objective3.enabled = false;        
    }

    // Update is called once per frame
    void Update()
    {
        if(Obj_banjocollection)
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
        

    }
}
