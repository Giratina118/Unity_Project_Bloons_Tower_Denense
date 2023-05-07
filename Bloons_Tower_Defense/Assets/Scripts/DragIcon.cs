using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class DragIcon : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Image image;
    public Tower2 m_CloneTower = null;
    public Image DragingIcon = null;
    public SetTowerBool setTower;


    public void OnBeginDrag(PointerEventData eventData)
    {
        image.color = new Color(1f, 1f, 1f, 0.5f);
        DragingIcon.sprite = GetComponent<Image>().sprite;
        DragingIcon.gameObject.SetActive(true);

    }

    public void OnDrag(PointerEventData eventData)
    {
        DragingIcon.transform.position = eventData.position;

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



        if( setTower.ISAbleMap1Bool(wpos) )
        {
            Tower2 towclone = GameObject.Instantiate(m_CloneTower);
            towclone.SetSprite(GetComponent<Image>().sprite);

            towclone.transform.position = wpos;

            setTower.setMap1Bool();
        }


        //Tilemap m_TempTilemap = null;
        //TileBase datatile = m_TempTilemap.GetTile(new Vector3Int(1, 0,0) );
        


    }

    public void setField()
    {
        
    }


    void Start()
    {
        image = GetComponent<Image>();
        //setTower = GetComponent<SetTowerBool>();

        setTower = GameObject.FindObjectOfType<SetTowerBool>();

        //setTower = new bool[10, 14];
        //for (int i = 0; i < 10; i++)
        //    for (int j = 0; j < 14; j++)
        //        setTower[i, j] = GetComponent<SetTowerBool>().isAble[i, j];

        //setTower = GetComponent<SetTowerBool>().isAble;
    }

    void Update()
    {

    }

}
