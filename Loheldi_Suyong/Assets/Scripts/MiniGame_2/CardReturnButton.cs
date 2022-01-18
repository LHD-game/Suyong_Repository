using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CardReturnButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;
    private bool playerBool = false;

    void Update()
    {
        if (playerBool)
        {
            CardGameManager.Timer = 64f;
            Time.timeScale = 1;
            CardGameManager.GameStart = false;
        }
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