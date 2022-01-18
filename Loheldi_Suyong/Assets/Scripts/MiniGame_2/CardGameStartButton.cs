using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CardGameStartButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool playerBool = false;

    public GameObject Title;
    public GameObject Rule;
    public GameObject RuleButton;
    public GameObject StartButton;
    public GameObject ReturnButton;

    void Update()
    {
        if (playerBool)
        {
            CardGameManager.GameStart = true;
            Title.SetActive(false);
            Rule.SetActive(false);
            RuleButton.SetActive(false);
            ReturnButton.SetActive(false);
            StartButton.SetActive(false);
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