using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
    public int gold = 200;
    public int bananaFarm = 0;

    void Start()
    {

    }

    void Update()
    {
        this.GetComponent<TMP_Text>().text = "GOLD  " + gold;
    }
}
