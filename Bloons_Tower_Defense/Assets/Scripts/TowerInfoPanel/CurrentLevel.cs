using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentLevel : MonoBehaviour
{

    public void WriteLevel(int level)
    {
        this.GetComponent<TMP_Text>().text = "level :  " + level;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
