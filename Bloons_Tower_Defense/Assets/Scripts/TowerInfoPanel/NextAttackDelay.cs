using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NextAttackDelay : MonoBehaviour
{

    public void WriteNextAttackDelay(float delay, int level)
    {
        if (level == 3)
            this.GetComponent<TMP_Text>().text = "Delay :  MAX";
        else
            this.GetComponent<TMP_Text>().text = "Delay :  " + delay;
    }

    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
