using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MiniTestMenu_3 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool playerBool = false;

    void Update()
    {
        if (playerBool)
        {
            SceneManager.LoadScene("MiniGame_RunMenu");
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