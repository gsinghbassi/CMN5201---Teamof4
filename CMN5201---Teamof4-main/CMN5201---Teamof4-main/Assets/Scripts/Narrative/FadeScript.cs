using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    [SerializeField] private CanvasGroup UiGroup;


    public void ShowUI()
    {
        UiGroup.alpha = 1;
    }

    public void HideUI()
    {
        UiGroup.alpha = 0;
    }
}