using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    public int round = 0;
    int[] balloons = new int[300];
    
    public bool creating = false;
    public CreatBalloon creatBalloon;
    public GoldManager goldManager;

    float createDelayTime = 0.5f;

    public void ButtonClick()
    {
        if (creatBalloon.balloonsList.Count == 0 && !creating)
        {
            StartCoroutine("roundBalloons");
        }
    }

    public IEnumerator roundBalloons()
    {
        creating = true;
        for (int i = 0; i < balloons.Length; i++)
        {
            if (balloons[i] == -1)
                break;
            balloons[i] = -1;
        }

        round++;
        int balloonCount = 0;

        switch (round)
        {
            case 1:
                for (int i = 0; i < 12; i++)
                {
                    balloons[balloonCount] = 0;
                    balloonCount++;
                }
                break;
            case 2:
                for (int i = 0; i < 25; i++)
                {
                    balloons[balloonCount] = 0;
                    balloonCount++;
                }
                break;
            case 3:
                for (int i = 0; i < 24; i++)
                {
                    balloons[balloonCount] = 0;
                    balloonCount++;
                }
                for (int i = 0; i < 5; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                break;
            case 4:
                for (int i = 0; i < 10; i++)
                {
                    balloons[balloonCount] = 0;
                    balloonCount++;
                }
                for (int i = 0; i < 24; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                break;
            case 5:
                for (int i = 0; i < 30; i++)
                {
                    balloons[balloonCount] = 0;
                    balloonCount++;
                }
                for (int i = 0; i < 25; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                break;
            case 6:
                for (int i = 0; i < 15; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                break;
            case 7:
                for (int i = 0; i < 75; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                break;
            case 8:
                for (int i = 0; i < 115; i++)
                {
                    balloons[balloonCount] = 0;
                    balloonCount++;
                }
                for (int i = 0; i < 68; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                break;
            case 9:
                for (int i = 0; i < 49; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                for (int i = 0; i < 22; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                break;
            case 10:
                for (int i = 0; i < 40; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                break;
            case 11:
                for (int i = 0; i < 24; i++)
                {
                    balloons[balloonCount] = 3;
                    balloonCount++;
                }
                break;
            case 12:
                for (int i = 0; i < 30; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                for (int i = 0; i < 25; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                for (int i = 0; i < 3; i++)
                {
                    balloons[balloonCount] = 3;
                    balloonCount++;
                }
                break;
            case 13:
                for (int i = 0; i < 40; i++)
                {
                    balloons[balloonCount] = 0;
                    balloonCount++;
                }
                for (int i = 0; i < 75; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                for (int i = 0; i < 30; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                break;
            case 14:
                for (int i = 0; i < 26; i++)
                {
                    balloons[balloonCount] = 3;
                    balloonCount++;
                }
                break;
            case 15:
                for (int i = 0; i < 30; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                for (int i = 0; i < 60; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                break;
            case 16:
                for (int i = 0; i < 80; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                for (int i = 0; i < 80; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                break;
            case 17:
                for (int i = 0; i < 150; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                for (int i = 0; i < 30; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                break;
            case 18:
                for (int i = 0; i < 30; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                for (int i = 0; i < 26; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                for (int i = 0; i < 28; i++)
                {
                    balloons[balloonCount] = 3;
                    balloonCount++;
                }
                break;
            case 19:
                for (int i = 0; i < 92; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                break;
            case 20:
                for (int i = 0; i < 40; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                for (int i = 0; i < 60; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                break;
            case 21:
                for (int i = 0; i < 10; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                for (int i = 0; i < 85; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                for (int i = 0; i < 30; i++)
                {
                    balloons[balloonCount] = 3;
                    balloonCount++;
                }
                break;
            case 22:
                for (int i = 0; i < 45; i++)
                {
                    balloons[balloonCount] = 3;
                    balloonCount++;
                }
                break;
            case 23:
                for (int i = 0; i < 35; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                for (int i = 0; i < 64; i++)
                {
                    balloons[balloonCount] = 3;
                    balloonCount++;
                }
                break;
            case 24:
                for (int i = 0; i < 20; i++)
                {
                    balloons[balloonCount] = 1;
                    balloonCount++;
                }
                for (int i = 0; i < 60; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                for (int i = 0; i < 30; i++)
                {
                    balloons[balloonCount] = 3;
                    balloonCount++;
                }
                break;
            case 25:
                for (int i = 0; i < 80; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                for (int i = 0; i < 50; i++)
                {
                    balloons[balloonCount] = 3;
                    balloonCount++;
                }
                break;
            case 26:
                for (int i = 0; i < 85; i++)
                {
                    balloons[balloonCount] = 3;
                    balloonCount++;
                }
                break;
            case 27:
                for (int i = 0; i < 20; i++)
                {
                    balloons[balloonCount] = 5;
                    balloonCount++;
                }
                break;
            case 28:
                for (int i = 0; i < 40; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                for (int i = 0; i < 25; i++)
                {
                    balloons[balloonCount] = 4;
                    balloonCount++;
                }
                break;
            case 29:
                for (int i = 0; i < 125; i++)
                {
                    balloons[balloonCount] = 3;
                    balloonCount++;
                }
                for (int i = 0; i < 20; i++)
                {
                    balloons[balloonCount] = 5;
                    balloonCount++;
                }
                break;
            case 30:
                for (int i = 0; i < 252; i++)
                {
                    balloons[balloonCount] = 2;
                    balloonCount++;
                }
                break;
            case 31:
                for (int i = 0; i < 20; i++)
                {
                    balloons[balloonCount] = 5;
                    balloonCount++;
                }
                for (int i = 0; i < 20; i++)
                {
                    balloons[balloonCount] = 4;
                    balloonCount++;
                }
                break;
            case 32:
                for (int i = 0; i < 25; i++)
                {
                    balloons[balloonCount] = 3;
                    balloonCount++;
                }
                for (int i = 0; i < 20; i++)
                {
                    balloons[balloonCount] = 4;
                    balloonCount++;
                }
                break;
            case 33:
                for (int i = 0; i < 150; i++)
                {
                    balloons[balloonCount] = 4;
                    balloonCount++;
                }
                break;
            case 34:
                break;
            case 35:
                break;
            case 36:
                break;
            case 37:
                break;
            case 38:
                break;
            case 39:
                break;
            case 40:
                break;
            case 41:
                break;
            case 42:
                break;
            case 43:
                break;
            case 44:
                break;
            case 45:
                break;
            case 46:
                break;
            case 47:
                break;
            case 48:
                break;
            case 49:
                break;
            case 50:
                break;
            default:
                break;
        }

        for (int i = 0; i < balloonCount; i++)
        {
            creatBalloon.Creat(creatBalloon.copyBalloonObj[balloons[i]]);

            IEnumerator delay = TimeDelay(createDelayTime);
            yield return StartCoroutine(delay);
            StopCoroutine(delay);
        }


        
        
    }


    private IEnumerator TimeDelay(float dTime)
    {
        yield return new WaitForSeconds(dTime);
    }

    void Start()
    {
        for (int i = 0; i < balloons.Length; i++)
        {
            balloons[i] = -1;
        }
    }


    void Update()
    {
        this.GetComponent<TMP_Text>().text = round + " Round";


        if (creatBalloon.balloonsList.Count == 0 && creating)
        {
            creating = false;
            goldManager.gold += (goldManager.bananaFarm * 50 + 50 + round * 10);
        }
    }
}
