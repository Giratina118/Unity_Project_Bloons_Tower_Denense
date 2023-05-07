using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int movePointNumber = 13;
    int CurrentmovePoint = 0;
    public Transform[] movePoint;
    public int balloonHP = 1;
    public float balloonSpeed = 10.0f;
    public int getGold = 5;

    public CreatBalloon CreatBalloon;
    public GoldManager gold;

    void Start()
    {
        BalloonStart();
    }

    void Update()
    {
        BalloonMove();
        
    }


    void BalloonStart()
    {
        transform.position = movePoint[0].position;
    }

    void BalloonMove()
    {
        BalloonEnd();

        Vector2 nextPos = movePoint[CurrentmovePoint + 1].position;

        if (Mathf.Abs(transform.position.x - nextPos.x) > Mathf.Abs(transform.position.y - nextPos.y))
        {
            if (nextPos.x > transform.position.x)
                transform.Translate(0.1f * balloonSpeed * Time.deltaTime, 0.0f, 0.0f);
            else
                transform.Translate(-0.1f * balloonSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        else
        {
            if (nextPos.y > transform.position.y)
                transform.Translate(0.0f, 0.1f * balloonSpeed * Time.deltaTime, 0.0f);
            else
                transform.Translate(0.0f, -0.1f * balloonSpeed * Time.deltaTime, 0.0f);
        }

        if (Vector2.Distance(transform.position, nextPos) < 0.1f)
        {
            CurrentmovePoint++;
            transform.position = movePoint[CurrentmovePoint].position;

            BalloonEnd();
        }
    }

    void BalloonEnd()
    {
        if (movePointNumber - 1 == CurrentmovePoint || balloonHP <= 0)
        {
            CreatBalloon.DestroyBalloons(this);
            gold.gold += getGold;
        }
    }

}
