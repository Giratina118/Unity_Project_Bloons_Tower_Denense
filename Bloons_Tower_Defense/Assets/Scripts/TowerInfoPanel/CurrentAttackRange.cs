using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentAttackRange : MonoBehaviour
{

    public void WriteRange(float range)
    {
        this.GetComponent<TMP_Text>().text = "Range :  " + range;
    }

    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
