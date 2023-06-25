using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NextAttackRange : MonoBehaviour
{

    public void WriteNextAttackRange(float range, int level)
    {
        if (level == 3)
            this.GetComponent<TMP_Text>().text = "Range :  MAX";
        else
            this.GetComponent<TMP_Text>().text = "Range :  " + range;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
