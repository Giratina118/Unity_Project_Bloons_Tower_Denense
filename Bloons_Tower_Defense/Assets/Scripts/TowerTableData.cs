using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
[CreateAssetMenu(fileName = "TowerTable", menuName = "타워/타워값용", order = int.MaxValue)]
public class TowerTableData : ScriptableObject
{
    public float attRange = 2.0f;
    public float attDelay = 0.5f;
    public int attDamage = 1;
    public int price = 100;
    public int towerAbility = 0;
    public int curLv = 1;

    public Sprite IconSprite = null;

    [TextArea(4, 6)]
    public string Description = "";
}
