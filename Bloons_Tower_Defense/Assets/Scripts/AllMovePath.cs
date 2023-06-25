using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllMovePath : MonoBehaviour
{
    public Color DebugLineColor = Color.red;
    public List<NextPath> m_AllPathList = new List<NextPath>();

    private void OnDrawGizmosSelected()
    {
        if (m_AllPathList.Count < 2)
        {
            return;
        }

        Color prevcol = Gizmos.color;
        for (int i = 0; i < m_AllPathList.Count - 1; i++)
        {
            Transform stpos = m_AllPathList[i].transform;
            Transform endpos = m_AllPathList[i + 1].transform;

            Gizmos.color = DebugLineColor;
            Gizmos.DrawLine(stpos.position, endpos.position);
            Gizmos.color = Color.red;

            Gizmos.DrawWireSphere(endpos.position, 0.2f);

        }

        Gizmos.color = prevcol;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
