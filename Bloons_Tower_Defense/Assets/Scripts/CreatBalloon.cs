using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatBalloon : MonoBehaviour
{
    public GameObject[] copyBalloonObj;
    GameObject cloneObj;
    public List<Balloon> balloonsList = null;

    void Start()
    {
        balloonsList = new List<Balloon>();
    }

    void Update()
    {
        
    }

    public void Creat(GameObject copyObj)
    {
        cloneObj = GameObject.Instantiate(copyObj);
        cloneObj.SetActive(true);

        Balloon cloneBalloon = cloneObj.GetComponent<Balloon>();
        balloonsList.Add(cloneBalloon);

    }
    
    public void DestroyBalloons(Balloon balloon)
    {
        balloonsList.Remove(balloon);
        Destroy(balloon.gameObject);
    }
}
