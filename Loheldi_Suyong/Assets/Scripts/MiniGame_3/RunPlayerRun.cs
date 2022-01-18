using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RunPlayerRun : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;
    public GameObject Marker;
    public new GameObject camera;
    private bool playerBool = false;
    public bool CameraWork = false;
    int count = 0;


    void Update()
    {
        if (playerBool)
        {
            if (RunCountDown.CountEnd == true)
            {
                player.gameObject.transform.Translate(new Vector3(0, 0, 3));
                Marker.transform.Translate(new Vector3(-0.5f, 0, 0));
                if (count == 40)
                {
                    CameraWork = true;
                }
                count++;
                playerBool = false;
            }
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