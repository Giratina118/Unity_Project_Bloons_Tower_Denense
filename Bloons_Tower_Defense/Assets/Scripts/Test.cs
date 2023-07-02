using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
        DataManager.Instance.data.isClear[0] = false;
        DataManager.Instance.data.isClear[1] = false;
        DataManager.Instance.SaveGameData();
    }

    void Update()
    {
        
    }
}
