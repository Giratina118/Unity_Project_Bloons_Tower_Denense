using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentAttackDamage : MonoBehaviour
{

    public void WriteDamage(int damage)
    {
        this.GetComponent<TMP_Text>().text = "Damage :  " + damage;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
