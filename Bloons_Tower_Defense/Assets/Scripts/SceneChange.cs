using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{


    public void TitleMapScene()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void MapSelectScene()
    {
        SceneManager.LoadScene("MapSelectScene");
    }

    public void Map1()
    {
        SceneManager.LoadScene("Map1");
    }

    public void Map2()
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
