using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int movePointNumber = 13;
    int CurrentmovePoint = 0;
    public int balloonHP = 1;
    public float balloonSpeed = 1.0f;
    public int getGold = 5;
    public int balloonNumber = 0;

    public CreatBalloon CreatBalloon;
    public GoldManager gold;
    public HPManager hp;
    public float moveDistance = 0.0f;

    public bool isIceBool = false;
    public float iceTimer = 0.0f;

    public float createdTime = 0.0f;


    public List<AllMovePath> m_allmovePathList = new List<AllMovePath>();
    public RoundManager round = null;
    public List<NextPath> movePoint = new List<NextPath>();


    void PathSelect()
    {
        movePoint = m_allmovePathList[round.balloonPath].m_AllPathList;
    }


    void Start()
    {
        createdTime = Time.time;
        PathSelect();
        BalloonStart();
    }

    void Update()
    {
        BalloonMove();
        if (isIceBool)
        {
            ice();
        }
    }


    void BalloonStart()
    {
        movePointNumber = movePoint.Count;
        transform.position = movePoint[0].transform.position;
    }

    void BalloonMove()
    {
        BalloonEnd();

        Vector2 nextPos = movePoint[CurrentmovePoint + 1].transform.position;

        if (Mathf.Abs(transform.position.x - nextPos.x) > Mathf.Abs(transform.position.y - nextPos.y))
        {
            if (nextPos.x > transform.position.x)
                transform.Translate(balloonSpeed * Time.deltaTime, 0.0f, 0.0f);
            else
                transform.Translate(-1.0f * balloonSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        else
        {
            if (nextPos.y > transform.position.y)
                transform.Translate(0.0f, balloonSpeed * Time.deltaTime, 0.0f);
            else
                transform.Translate(0.0f, -1.0f * balloonSpeed * Time.deltaTime, 0.0f);
        }

        if (Vector2.Distance(transform.position, nextPos) < 0.1f)
        {
            CurrentmovePoint++;
            transform.position = movePoint[CurrentmovePoint].transform.position;

            BalloonEnd();
        }
        moveDistance += balloonSpeed * Time.deltaTime;

    }

    void BalloonEnd()
    {
        if (balloonHP <= 0)
        {
            gold.gold++;
            CreatBalloon.DestroyBalloons(this);
        }
        else if (movePointNumber - 1 == CurrentmovePoint)
        {
            hp.hp -= balloonHP;
            CreatBalloon.DestroyBalloons(this);
        }
    }

    void ice()
    {
        iceTimer += Time.deltaTime;
        if (iceTimer >= 2.0f)
        {
            isIceBool = false;
            balloonSpeed *= 2;
        }
    }

    public void SetDamage( int p_dmg )
    {
        balloonHP -= p_dmg;
        // 데미지 효과

        StartCoroutine(SetDamageCoroutine());
    }

    public float DamageSpeed = 0.1f;
    IEnumerator SetDamageCoroutine()
    {
        SpriteRenderer render = GetComponent<SpriteRenderer>();
        Color currcol = Color.white;
        render.color = currcol;

        // 색상 다운하기
        while(true)
        {
            currcol.r -= DamageSpeed;
            currcol.g -= DamageSpeed;
            currcol.b -= DamageSpeed;

            render.color = currcol;

            yield return null;
            if (currcol.r <= 0.5f)
                break;
        }


        while (true)
        {
            currcol.r += DamageSpeed;
            currcol.g += DamageSpeed;
            currcol.b += DamageSpeed;

            render.color = currcol;
            yield return null;
            if (currcol.r >= 1f)
                break;
        }


        render.color = Color.white;
    }

}
