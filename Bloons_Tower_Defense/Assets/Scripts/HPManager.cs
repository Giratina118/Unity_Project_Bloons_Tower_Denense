using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HPManager : MonoBehaviour
{
    public int hp = 200;

    void Start()
    {
        
    }


    void Update()
    {
        this.GetComponent<TMP_Text>().text = "HP  " + hp;
    }
}
