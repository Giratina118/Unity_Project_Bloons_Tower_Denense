using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTowerBool : MonoBehaviour
{
    public bool[,] isAble;
    int x, y;

    public bool ISAbleMap1Bool(Vector2 p_wpos)
    {
        x = (int)Mathf.Floor(p_wpos.x) + 8;
        y = 4 - (int)Mathf.Floor(p_wpos.y);
        if (y < 0 || y > 9 || x < 0 || x > 13)
            return false;
        else
            return isAble[y, x];
    }

    public void setMap1Bool()
    {
        isAble[y, x] = false;
    }

    public void setMap1Start()
    {
        isAble = new bool[10, 14];

        for (int i  = 0; i < 10; i++)
            for (int j = 0; j < 14; j++)
                isAble[i, j] = true;

        for (int i = 5; i < 9; i++)
            isAble[0, i] = false;

        for (int i = 0; i < 9; i++)
            isAble[3, i] = false;

        for (int i = 2; i < 11; i++)
            isAble[5, i] = false;

        for (int i = 7; i < 13; i++)
            isAble[7, i] = false;

        for (int i = 2; i < 6; i++)
            isAble[8, i] = false;

        for (int i = 1; i < 8; i++)
            isAble[i, 5] = false;

        for (int i = 2; i < 7; i++)
            isAble[i, 12] = false;

        isAble[1, 8] = isAble[2, 8] = isAble[2, 10] = isAble[2, 11] = isAble[3, 10] 
            = isAble[4, 10] = isAble[6, 2] = isAble[7, 2] = isAble[8, 7] = false;
        
    }

    void Start()
    {
        setMap1Start();
    }

    void Update()
    {
        
    }
}
