using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMapButton : MonoBehaviour
{

    public void Map1Select()
    {
        SceneManager.LoadScene("Map1");
    }

    public void Map2Select()
    {
        SceneManager.LoadScene("Map2");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
