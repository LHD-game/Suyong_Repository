using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;



public class CardGameManager : MonoBehaviour
{
    public List<GameObject> CardList = new List<GameObject>();
    public List<GameObject> TempCardList = new List<GameObject>();
    private List<GameObject> MixCardList = new List<GameObject>();
    private List<GameObject> AllCard = new List<GameObject>();

    public static GameObject OpenCard;
    public static GameObject LastCard;
    public static bool GameStart;
    public GameObject FndText;
    public GameObject EndText;
    public GameObject EndButton;

    public GameObject Title;
    public GameObject Rule;
    public GameObject RuleButton;
    public GameObject StartButton;
    public GameObject ReturnButton;

    int cardCnt;
    int flipCnt = 0;

    static public int stageNum = 1;
    int stageCount = 3;
    public static float Timer = 64f;
    public Text timeText;

    public enum STATE
    {
        START, HIT, WAIT, IDLE, CLEAR, FAIL
    };
    static public STATE state;

    void Start()
    {
        state = STATE.START;
        GameStart = false;
    }

    void Update()
    {
        if (GameStart)
        {
            switch (state)
            {
                case STATE.START:
                    SetUp();
                    break;
                case STATE.HIT:
                    CheckCard();
                    break;
                case STATE.CLEAR:
                    StartCoroutine(StageClear());
                    break;
                case STATE.WAIT:
                    break;
                case STATE.FAIL:
                    StageFail();
                    break;
                case STATE.IDLE:
                    Timer -= Time.deltaTime;
                    break;

            }
            if (Timer <= 60f)
            {
                timeText.text = string.Format("{0:N2}", Timer);
            }
            else
            {
                int a = 60;
                timeText.text = a.ToString();
            }
            if (Timer <= 0)
            {
                state = STATE.FAIL;
            }
        }
        else
        {
            Title.SetActive(true);
            Rule.SetActive(true);
            RuleButton.SetActive(true);
            StartButton.SetActive(true);
            ReturnButton.SetActive(true);
        }
    }

    void CheckCard()
    {
        state = STATE.WAIT;

        if (LastCard == null)
        {
            LastCard = OpenCard;
            state = STATE.IDLE;
            return;
        }
        if (LastCard.gameObject.tag != OpenCard.gameObject.tag)
        {
            StartCoroutine(CloseTwoCards());
            state = STATE.IDLE;
            return;
        }
        if (LastCard.gameObject.tag == OpenCard.gameObject.tag)
        {
            flipCnt = flipCnt + 2;

            LastCard.SendMessage("DestroyCard", SendMessageOptions.DontRequireReceiver);
            OpenCard.SendMessage("DestroyCard", SendMessageOptions.DontRequireReceiver);

            if (flipCnt == cardCnt)
            {
                state = STATE.CLEAR;
                return;
            }
        }
        LastCard = null;
        state = STATE.IDLE;
    }
    void SetUp()
    {
        TempCardList.Clear();
        AllCard.Clear();

        if (stageNum == 1)
        {
            TempCardList.Add(CardList[0]);
            TempCardList.Add(CardList[0]);
            TempCardList.Add(CardList[1]);
            TempCardList.Add(CardList[1]);
            TempCardList.Add(CardList[2]);
            TempCardList.Add(CardList[2]);
            TempCardList.Add(CardList[3]);
            TempCardList.Add(CardList[3]);
            cardCnt = 8;
        }
        else if (stageNum == 2)
        {
            TempCardList.Add(CardList[0]);
            TempCardList.Add(CardList[0]);
            TempCardList.Add(CardList[1]);
            TempCardList.Add(CardList[1]);
            TempCardList.Add(CardList[2]);
            TempCardList.Add(CardList[2]);
            TempCardList.Add(CardList[3]);
            TempCardList.Add(CardList[3]);
            TempCardList.Add(CardList[4]);
            TempCardList.Add(CardList[4]);
            TempCardList.Add(CardList[5]);
            TempCardList.Add(CardList[5]);
            TempCardList.Add(CardList[6]);
            TempCardList.Add(CardList[6]);
            TempCardList.Add(CardList[7]);
            TempCardList.Add(CardList[7]);
            cardCnt = 16;
        }
        else if (stageNum == 3)
        {
            TempCardList.Add(CardList[0]);
            TempCardList.Add(CardList[0]);
            TempCardList.Add(CardList[1]);
            TempCardList.Add(CardList[1]);
            TempCardList.Add(CardList[2]);
            TempCardList.Add(CardList[2]);
            TempCardList.Add(CardList[3]);
            TempCardList.Add(CardList[3]);
            TempCardList.Add(CardList[4]);
            TempCardList.Add(CardList[4]);
            TempCardList.Add(CardList[5]);
            TempCardList.Add(CardList[5]);
            TempCardList.Add(CardList[6]);
            TempCardList.Add(CardList[6]);
            TempCardList.Add(CardList[7]);
            TempCardList.Add(CardList[7]);
            TempCardList.Add(CardList[8]);
            TempCardList.Add(CardList[8]);
            TempCardList.Add(CardList[9]);
            TempCardList.Add(CardList[9]);
            TempCardList.Add(CardList[10]);
            TempCardList.Add(CardList[10]);
            TempCardList.Add(CardList[11]);
            TempCardList.Add(CardList[11]);
            cardCnt = 24;
        }
        Timer = 64f;
        StartCoroutine(MakeStage());
    }
    void Clear()
    {
        EndText.SetActive(true);
        EndButton.SetActive(true);
        Time.timeScale = 0;
    }

    IEnumerator CloseTwoCards()
    {
        yield return new WaitForSeconds(0.2f);
        LastCard.SendMessage("CloseCard", SendMessageOptions.DontRequireReceiver);
        OpenCard.SendMessage("CloseCard", SendMessageOptions.DontRequireReceiver);
    }
    IEnumerator StageClear()
    {
        state = STATE.WAIT;

        ++stageNum;
        flipCnt = 0;

        yield return new WaitForSeconds(1);
        state = STATE.START;
        if (stageNum == 4)
        {
            Clear();
            state = STATE.WAIT;
        }
    }
    void StageFail()
    {

        FndText.SetActive(true);
        EndButton.SetActive(true);
        Time.timeScale = 0;
    }
    IEnumerator MakeStage()
    {
        state = STATE.WAIT;

        float sx = 0;
        float sz = 0;
        ShuffleCard();
        SetCardPos(out sx, out sz);

        int n = 1;

        string[] str = SetStage.stage[stageNum - 1];
        foreach (string t in str)
        {
            char[] ch = t.Trim().ToCharArray();
            float x = sx;

            foreach (char c in ch)
            {

                switch (c)
                {
                    case '*':

                        GameObject Tempcard = Instantiate(TempCardList[n - 1]);
                        Tempcard.transform.position = new Vector3(x, 0, sz);
                        AllCard.Add(Tempcard);

                        x++;
                        n++;
                        break;
                    case '.':
                        x++;
                        break;
                }

                if (c == '*')
                {
                    yield return new WaitForSeconds(0.03f);
                }
            }
            sz--;
        }
        for (int k = 0; k != cardCnt; k++)
        {
            AllCard[k].SendMessage("OpenCard", SendMessageOptions.DontRequireReceiver);
        }
        yield return new WaitForSeconds(3);
        for (int k = 0; k != cardCnt; k++)
        {
            AllCard[k].SendMessage("CloseCard", SendMessageOptions.DontRequireReceiver);
        }
        state = STATE.IDLE;
    }

    void SetCardPos(out float sx, out float sz)
    {
        float x = 0;
        float z = 0;
        string[] str = SetStage.stage[stageNum - 1];

        for (int i = 0; i < str.Length; i++)
        {
            string t = str[i].Trim();
            x = 0;

            for (int j = 0; j < t.Length; j++)
            {
                switch (t[j])
                {
                    case '.':
                    case '*':
                        x++;
                        break;
                }
            }
            z = z + 0.5f;
        }
        sx = (x - 1) / 2 - 4;
        sz = (z - 1) / 2;
    }
    
    void ShuffleCard()
    {
        int count = TempCardList.Count;
        for (int i = 0; i < count; i++)
        {
            int rand = Random.Range(0, TempCardList.Count);
            MixCardList.Add(TempCardList[rand]);
            TempCardList.RemoveAt(rand);
        }
        TempCardList = MixCardList;
    }
}