using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategorySelect : MonoBehaviour
{
    public GameObject Skin;
    public GameObject Eye;
    public GameObject Mouth;
    public GameObject Hair;
    public GameObject H_Color;
    public GameObject Accessory;

    private GameObject Buttons1;
    private GameObject Buttons2;
    private GameObject Buttons3;
    private GameObject Buttons4;
    private GameObject Buttons5;
    private GameObject Buttons6;

    private int Category;

    void Start()
    {
        Buttons1 = Skin.transform.Find("Buttons").gameObject;
        Buttons2 = Eye.transform.Find("Buttons").gameObject;
        Buttons3 = Mouth.transform.Find("Buttons").gameObject;
        Buttons4 = Hair.transform.Find("Buttons").gameObject;
        Buttons5 = H_Color.transform.Find("Buttons").gameObject;
        Buttons6 = Accessory.transform.Find("Buttons").gameObject;
        PositionReset();

        Category = 6;
    }

    void Update()
    {
    }

    public void skin()
    {
        PositionReset();
        Category = 1;
        Buttons1.SetActive(true);
    }
    public void eye()
    {
        PositionReset();
        Category = 2;
        Buttons2.SetActive(true);
    }
    public void mouth()
    {
        PositionReset();
        Category = 3;
        Buttons3.SetActive(true);
    }
    public void hair()
    {
        PositionReset();
        Category = 4;
        Buttons4.SetActive(true);
    }
    public void hair_color()
    {
        PositionReset();
        Category = 5;
        Buttons5.SetActive(true);
    }
    public void accessory()
    {
        PositionReset();
        Category = 6;
        Buttons6.SetActive(true);
    }

    void PositionReset()
    {
        Buttons1.SetActive(false);
        Buttons2.SetActive(false);
        Buttons3.SetActive(false);
        Buttons4.SetActive(false);
        Buttons5.SetActive(false);
        Buttons6.SetActive(false);
    }
}
