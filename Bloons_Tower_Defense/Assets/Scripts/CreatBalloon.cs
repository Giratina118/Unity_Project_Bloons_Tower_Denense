using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatBalloon : MonoBehaviour
{
    public GameObject copyObj;
    GameObject cloneObj;
    public List<Balloon> balloonsList = null;


    void Start()
    {
        balloonsList = new List<Balloon>();
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

            Balloon cloneBalloon = cloneObj.GetComponent<Balloon>();
            balloonsList.Add(cloneBalloon);
        }
    }

    public void DestroyBalloons(Balloon balloon)
    {
        balloonsList.Remove(balloon);
        Destroy(balloon.gameObject);
    }
}
