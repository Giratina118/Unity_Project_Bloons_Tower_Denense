using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleGameStartButton : MonoBehaviour
{
    public void ButtonClick()
    {
        SceneManager.LoadScene("MapSelectScene");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
