using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NextAttackDamage : MonoBehaviour
{

    public void WriteNextAttackDamage(int damage, int level)
    {
        if (level == 3)
            this.GetComponent<TMP_Text>().text = "Damage :  MAX";
        else
        {
            damage += 1;
            this.GetComponent<TMP_Text>().text = "Damage :  " + damage;
        }
            
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
