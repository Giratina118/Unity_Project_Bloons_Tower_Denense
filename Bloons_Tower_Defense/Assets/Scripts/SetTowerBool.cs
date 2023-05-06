using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTowerBool : MonoBehaviour
{
    public bool[ , ] isAble;


    public void setMap1Bool(int x, int y)
    {
        isAble[x, y] = false;
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
            = isAble[4, 10] = isAble[6, 2] = isAble[7, 2] = isAble[8, 7] = isAble[8, 8] = false;
    }

    void Start()
    {
        setMap1Start();

    }


    void Update()
    {
        
    }
}
