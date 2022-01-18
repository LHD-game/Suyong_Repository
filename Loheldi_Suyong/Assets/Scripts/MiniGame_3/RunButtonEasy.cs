using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RunButtonEasy : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool playerBool = false;
    public bool CountStart = false;

    void Update()
    {
        if (playerBool)
        {
            RunGameManager.difficulty = 1;
            RunCountDown.CountStart = true;
        }
        playerBool = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        playerBool = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        playerBool = false;
    }
}
