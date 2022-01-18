using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopCategorySelect : MonoBehaviour
{
    public GameObject Buttons;
    private Text ButtonTxt;


    private GameObject Buttons1;
    private GameObject Buttons2;
    private GameObject Buttons3;
    private GameObject Buttons4;
    private GameObject Buttons5;
    private GameObject Buttons6;
    private Text PriceTxt;

    private int Category;
    private int Page;
    private int Price;

    void Start()
    {
        Price = 0;
        Category = 1;
        Page = 1;
        Buttons1 = Buttons.transform.FindChild("Button").gameObject;
        Buttons2 = Buttons.transform.FindChild("Button (1)").gameObject;
        Buttons3 = Buttons.transform.FindChild("Button (2)").gameObject;
        Buttons4 = Buttons.transform.FindChild("Button (3)").gameObject;
        Buttons5 = Buttons.transform.FindChild("Button (4)").gameObject;
        Buttons6 = Buttons.transform.FindChild("Button (5)").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Category == 1)
        {
            if (Page == 1)
            {
                ButtonTxt = Buttons1.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "A";
                ButtonTxt = Buttons2.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "B";
                ButtonTxt = Buttons3.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "C";
                ButtonTxt = Buttons4.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "D";
                ButtonTxt = Buttons5.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "E";
                ButtonTxt = Buttons6.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "F";
            }
            if (Page == 2)
            {
                ButtonTxt = Buttons1.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "G";
                ButtonTxt = Buttons2.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "H";
                ButtonTxt = Buttons3.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "I";
                ButtonTxt = Buttons4.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "J";
                ButtonTxt = Buttons5.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "K";
                ButtonTxt = Buttons6.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "L";
            }
        }
        else if (Category == 2)
        {
            if (Page == 1)
            {
                ButtonTxt = Buttons1.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "원목 A";
                ButtonTxt = Buttons2.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "원목 B";
                ButtonTxt = Buttons3.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "원목 C";
                ButtonTxt = Buttons4.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "원목 D";
                ButtonTxt = Buttons5.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "원목 E";
                ButtonTxt = Buttons6.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "원목 F";
            }
            if (Page == 2)
            {
                ButtonTxt = Buttons1.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "원목 G";
                ButtonTxt = Buttons2.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "원목 H";
                ButtonTxt = Buttons3.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "원목 I";
                ButtonTxt = Buttons4.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "원목 J";
                ButtonTxt = Buttons5.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "원목 K";
                ButtonTxt = Buttons6.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "원목 L";
            }
        }
        else if (Category == 3)
        {
            if (Page == 1)
            {
                ButtonTxt = Buttons1.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "모던 A";
                ButtonTxt = Buttons2.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "모던 B";
                ButtonTxt = Buttons3.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "모던 C";
                ButtonTxt = Buttons4.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "모던 D";
                ButtonTxt = Buttons5.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "모던 E";
                ButtonTxt = Buttons6.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "모던 F";
            }
            if (Page == 2)
            {
                ButtonTxt = Buttons1.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "모던 G";
                ButtonTxt = Buttons2.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "모던 H";
                ButtonTxt = Buttons3.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "모던 I";
                ButtonTxt = Buttons4.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "모던 J";
                ButtonTxt = Buttons5.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "모던 K";
                ButtonTxt = Buttons6.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "모던 L";
            }
        }
        else if (Category == 4)
        {
            if (Page == 1)
            {
                ButtonTxt = Buttons1.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "키치 A";
                ButtonTxt = Buttons2.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "키치 B";
                ButtonTxt = Buttons3.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "키치 C";
                ButtonTxt = Buttons4.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "키치 D";
                ButtonTxt = Buttons5.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "키치 E";
                ButtonTxt = Buttons6.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "키치 F";
            }
            if (Page == 2)
            {
                ButtonTxt = Buttons1.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "키치 G";
                ButtonTxt = Buttons2.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "키치 H";
                ButtonTxt = Buttons3.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "키치 I";
                ButtonTxt = Buttons4.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "키치 J";
                ButtonTxt = Buttons5.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "키치 K";
                ButtonTxt = Buttons6.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "키치 L";
            }
        }
        else if (Category == 5)
        {
            if (Page == 1)
            {
                ButtonTxt = Buttons1.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "클래식 A";
                ButtonTxt = Buttons2.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "클래식 B";
                ButtonTxt = Buttons3.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "클래식 C";
                ButtonTxt = Buttons4.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "클래식 D";
                ButtonTxt = Buttons5.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "클래식 E";
                ButtonTxt = Buttons6.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "클래식 F";
            }
            if (Page == 2)
            {
                ButtonTxt = Buttons1.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "클래식 G";
                ButtonTxt = Buttons2.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "클래식 H";
                ButtonTxt = Buttons3.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "클래식 I";
                ButtonTxt = Buttons4.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "클래식 J";
                ButtonTxt = Buttons5.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "클래식 K";
                ButtonTxt = Buttons6.transform.FindChild("Text").GetComponent<Text>();
                ButtonTxt.text = "클래식 L";
            }
        }
    }

    public void Cate1()
    {
        Category = 1;
        Page = 1;
    }
    public void Cate2()
    {
        Category = 2;
        Page = 1;
    }
    public void Cate3()
    {
        Category = 3;
        Page = 1;
    }
    public void Cate4()
    {
        Category = 4;
        Page = 1;
    }
    public void Cate5()
    {
        Category = 5;
        Page = 1;
    }

    public void PageL()
    {
        Page = 1;
    }
    public void PageR()
    {
        Page = 2;
    }
}
