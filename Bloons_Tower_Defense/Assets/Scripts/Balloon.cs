using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int movePointNumber = 14;
    public int CurrentmovePoint = 0;
    Transform[] movePoint;

    public float balloonSpeed = 1.0f;


    void Start()
    {
        
    }

    void BalloonStart()
    {
        movePoint = new Transform[movePointNumber];
        transform.position = movePoint[0].position;

    }

    void BalloonMove()
    {
        if (Vector2.Distance(transform.position, movePoint[CurrentmovePoint + 1].position) < 0.01f)
        {
            CurrentmovePoint++;
            transform.position = movePoint[CurrentmovePoint].position;
            
            BalloonEnd();
        }
        else
        {
            ////////////////////여기부터
            transform.Translate(0.0f, 0.0f, 0.0f);
        }

    }

    void BalloonEnd()
    {

    }

    void Update()
    {
        
    }
}
