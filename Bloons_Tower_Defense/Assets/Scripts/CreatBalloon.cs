using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatBalloon : MonoBehaviour
{
    public GameObject copyObj;
    GameObject cloneObj;

    void Start()
    {
        
    }


    void Update()
    {
        Creat();
    }

    void Creat()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            cloneObj = GameObject.Instantiate(copyObj);
            cloneObj.SetActive(true);
        }
    }
}
