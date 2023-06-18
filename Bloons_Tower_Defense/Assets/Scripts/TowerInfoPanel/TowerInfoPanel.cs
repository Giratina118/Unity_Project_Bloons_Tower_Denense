using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TowerInfoPanel : MonoBehaviour
{

    Tower m_LinkTowerData = null;
    public CurrentLevel currLevel;
    public CurrentAttackDamage currDamage;
    public CurrentAttackDelay currDelay;
    public CurrentAttackRange currRange;
    public NextAttackDamage nextDamage;
    public NextAttackDelay nextDelay;
    public NextAttackRange nextRange;
    public NextLevel nextLevel;

    public void InitSettings( Tower p_icon, int p_currlv )
    {
        m_LinkTowerData = p_icon;

        UpdateUI();
    }


    protected void UpdateUI()
    {
        currLevel.WriteLevel(m_LinkTowerData.level);
        currDamage.WriteDamage(m_LinkTowerData.attDamage);
        currDelay.WriteDelay(m_LinkTowerData.attDelay);
        currRange.WriteRange(m_LinkTowerData.attRange);

        nextDamage.WriteNextAttackDamage(m_LinkTowerData.attDamage, m_LinkTowerData.level);
        nextDelay.WriteNextAttackDelay(m_LinkTowerData.attDelay, m_LinkTowerData.level);
        nextRange.WriteNextAttackRange(m_LinkTowerData.attRange, m_LinkTowerData.level);
    }


    public void _On_ClosePanel()
    {
        this.gameObject.SetActive(false);
    }


    public void _On_LevelUP()
    {
        if (m_LinkTowerData.level == 1)
        {
            m_LinkTowerData.attDamage += 1;
            m_LinkTowerData.attDelay *= 0.8f;
            m_LinkTowerData.attRange += 0.5f;
            m_LinkTowerData.level++;
            UpdateUI();
        }
        else if (m_LinkTowerData.level == 2)
        {
            m_LinkTowerData.attDamage += 2;
            m_LinkTowerData.attDelay *= 0.7f;
            m_LinkTowerData.attRange += 0.5f;
            m_LinkTowerData.level++;
            UpdateUI();
        }
        else
        {
            nextLevel.WriteMaxLevel();
        }
        
        
    }



    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
