using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTowerBool : MonoBehaviour
{
    
    public bool[,] isAble;
    int x, y;
    public int mapNumber = 0;

    public bool ISAbleMapBool(Vector2 p_wpos)
    {
        x = (int)Mathf.Floor(p_wpos.x) + 8;
        y = 4 - (int)Mathf.Floor(p_wpos.y);
        if (y < 0 || y > 9 || x < 0 || x > 13)
            return false;
        else
            return isAble[y, x];
    }

    public void SetMapBool()
    {
        isAble[y, x] = false;
    }

    public void SetMapStart()
    {
        isAble = new bool[10, 14];

        for (int i  = 0; i < 10; i++)
            for (int j = 0; j < 14; j++)
                isAble[i, j] = true;


        switch (mapNumber)
        {
            case 0:
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
                break;
            case 1:
                for (int i = 3; i < 10; i++)
                    isAble[0, i] = false;

                for (int i = 4; i < 9; i++)
                    isAble[2, i] = false;

                for (int i = 1; i < 9; i++)
                    isAble[4, i] = false;

                for (int i = 4; i < 10; i++)
                    isAble[6, i] = false;

                for (int i = 3; i < 12; i++)
                    isAble[8, i] = false;


                for (int i = 4; i < 10; i++)
                    isAble[i, 0] = false;

                for (int i = 0; i < 9; i++)
                    isAble[i, 2] = false;

                for (int i = 0; i < 7; i++)
                    isAble[i, 10] = false;

                for (int i = 0; i < 9; i++)
                    isAble[i, 12] = false;

                isAble[3, 4] = isAble[3, 8] = isAble[5, 4] = false;
                break;

        }

        
        
    }

    void Start()
    {
        SetMapStart();
    }

    void Update()
    {
        
    }
}
