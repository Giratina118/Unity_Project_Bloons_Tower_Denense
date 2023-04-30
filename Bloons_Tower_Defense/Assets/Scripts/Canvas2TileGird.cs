using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas2TileGird : MonoBehaviour
{

    public Camera SceneCamera = null;


    public Vector3 Wpos = new Vector3();
    
    void Start()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 temppos = Wpos;


        temppos.x = Mathf.Round(temppos.x);
        temppos.y = Mathf.Round(temppos.y);
        temppos.z = 0;
        
        Gizmos.DrawWireCube(temppos, Vector3.one * 0.3f);
    }



    void Update()
    {
        Vector3 mousepos = Input.mousePosition;
        Vector3 wpos = SceneCamera.ScreenToWorldPoint(mousepos);

        Wpos = wpos;

        


    }
}
