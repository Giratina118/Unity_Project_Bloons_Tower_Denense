using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

/*
[System.Serializable]
public class TowerInfoData
{
    public Image ModelImage;
    public float attRange;
    public float attDelay;
    public int attDamage;
    public int price;
    public int towerAbility;
}
*/

public class DragIcon : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Image image;
    public TowerTableData TowerData = null;
    public Tower m_CloneTower = null;
    public Image DragingIcon = null;
    public TMP_Text m_PriceText = null;

    SetTowerBool setTower;
    GoldManager goldManager;

    public float attRange = 2.0f;
    public float attDelay = 0.5f;
    public int attDamage = 1;
    public int price = 100;
    public int towerAbility = 0;
    public int curLv = 1;



    public void OnBeginDrag(PointerEventData eventData)
    {
        image.color = new Color(1f, 1f, 1f, 0.5f);
        DragingIcon.sprite = GetComponent<Image>().sprite;
        DragingIcon.gameObject.SetActive(true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        DragingIcon.transform.position = eventData.position;
        DragingIcon.transform.localScale = this.transform.localScale;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.color = new Color(1f, 1f, 1f, 1f);
        DragingIcon.gameObject.SetActive(false);

        Vector3 mousepos = Input.mousePosition;
        Vector3 wpos = Camera.main.ScreenToWorldPoint(mousepos);

        wpos.x = Mathf.Floor(wpos.x) + 0.5f;
        wpos.y = Mathf.Floor(wpos.y) + 0.5f;
        wpos.z = -0.1f;


        if( setTower.ISAbleMapBool(wpos) && goldManager.gold >= price)
        {
            Tower towclone = GameObject.Instantiate(m_CloneTower);
            //towclone.SetSprite(this);
            towclone.SetSprite(GetComponent<Image>().sprite);

            towclone.transform.position = wpos;

            towclone.attRange = this.attRange;
            towclone.attDelay = this.attDelay;
            towclone.attDamage = this.attDamage;
            towclone.towerAbility = this.towerAbility;

            towclone.transform.localScale = this.transform.localScale;

            goldManager.gold -= price;
            setTower.SetMapBool();
            towclone.price = this.price * 2;

            if (towclone.towerAbility == 5)
            {
                goldManager.bananaFarm++;
            }
        }
    }

    [ContextMenu("[테스트 확인용]")]
    public void SetChangeDatas()
    {
        DragingIcon.sprite = TowerData.IconSprite;
        m_PriceText.text = $"{TowerData.price}";

        attRange = TowerData.attDamage;
        attDelay = TowerData.attDelay;
        attDamage = TowerData.attDamage;
        price = TowerData.price;
        towerAbility = TowerData.towerAbility;
        curLv = TowerData.curLv;

    }

    void Start()
    {
        SetChangeDatas();
        image = GetComponent<Image>();
        setTower = GameObject.FindObjectOfType<SetTowerBool>();
        goldManager = GameObject.FindObjectOfType<GoldManager>();
    }

    void Update()
    {

    }
}
