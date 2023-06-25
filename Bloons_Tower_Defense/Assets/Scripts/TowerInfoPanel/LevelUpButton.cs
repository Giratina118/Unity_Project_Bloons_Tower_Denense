using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelUpButton : MonoBehaviour
{

    public void WriteButtonText(int gold, int level)
    {
        if (level == 3)
            this.GetComponent<TMP_Text>().text = "Level UP :  MAX";
        else
            this.GetComponent<TMP_Text>().text = "Level UP :  " + gold + " GOLD";
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
