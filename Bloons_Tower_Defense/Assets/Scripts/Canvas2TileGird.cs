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

        temppos.x = Mathf.Floor(temppos.x) + 0.5f;
        temppos.y = Mathf.Floor(temppos.y) + 0.5f;
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
