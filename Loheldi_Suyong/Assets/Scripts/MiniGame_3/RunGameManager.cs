using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGameManager : MonoBehaviour
{
    public static int difficulty = 0;

    public Transform NPC1;
    public Transform NPC2;
    public Transform NPC3;
    public Transform Player;

    public GameObject RunButtonL;
    public GameObject RunButtonR;
    public GameObject Win_txt;
    public GameObject Lose_txt;
    public GameObject ReturnButton;
    
    void Start()
    {
        
        NPC1.gameObject.SetActive(false);
        NPC2.gameObject.SetActive(false);
        NPC3.gameObject.SetActive(false);
    }
    void Update()
    {
        if (difficulty == 1)
        {
            NPC1.gameObject.SetActive(true);
            if (NPC1.position.z >= 857)
            {
                NPC1.gameObject.GetComponent<RunHamiRun>().enabled = false;
                RunButtonL.gameObject.SetActive(false);
                RunButtonR.gameObject.SetActive(false);
                Lose_txt.gameObject.SetActive(true);
                ReturnButton.gameObject.SetActive(true);
            }
            if (Player.position.z >= 857)
            {
                NPC1.gameObject.GetComponent<RunHamiRun>().enabled = false;
                RunButtonL.gameObject.SetActive(false);
                RunButtonR.gameObject.SetActive(false);
                Win_txt.gameObject.SetActive(true);
                ReturnButton.gameObject.SetActive(true);
            }
        }
        if (difficulty == 2)
        {
            NPC2.gameObject.SetActive(true);
            if (NPC2.position.z >= 857)
            {
                NPC2.gameObject.GetComponent<RunNariRun>().enabled = false;
                RunButtonL.gameObject.SetActive(false);
                RunButtonR.gameObject.SetActive(false);
                Lose_txt.gameObject.SetActive(true);
                ReturnButton.gameObject.SetActive(true);
            }
            if (Player.position.z >= 857)
            {
                NPC2.gameObject.GetComponent<RunNariRun>().enabled = false;
                RunButtonL.gameObject.SetActive(false);
                RunButtonR.gameObject.SetActive(false);
                Win_txt.gameObject.SetActive(true);
                ReturnButton.gameObject.SetActive(true);
            }
        }
        if (difficulty == 3)
        {
            NPC3.gameObject.SetActive(true);
            if (NPC3.position.z >= 857)
            {
                NPC3.gameObject.GetComponent<RunHimchanRun>().enabled = false;
                RunButtonL.gameObject.SetActive(false);
                RunButtonR.gameObject.SetActive(false);
                Lose_txt.gameObject.SetActive(true);
                ReturnButton.gameObject.SetActive(true);
            }
            if (Player.position.z >= 857)
            {
                NPC3.gameObject.GetComponent<RunHimchanRun>().enabled = false;
                RunButtonL.gameObject.SetActive(false);
                RunButtonR.gameObject.SetActive(false);
                Win_txt.gameObject.SetActive(true);
                ReturnButton.gameObject.SetActive(true);
            }
        }
    }
}
