using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalManager : MonoBehaviour
{
    public Medal[] medals = new Medal[2];


    void MedalShow()
    {
        for (int i = 0; i < medals.Length; i++)
        {
            if (DataManager.Instance.data.isClear[i])
            {
                medals[i].gameObject.SetActive(true);
            }
        }
    }

    void Start()
    {
        DataManager.Instance.LoadGameData();
        MedalShow();
    }

    void Update()
    {
        
    }
}
