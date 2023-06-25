using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentAttackDelay : MonoBehaviour
{

    public void WriteDelay(float delay)
    {
        this.GetComponent<TMP_Text>().text = "Delay :  " + delay;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
