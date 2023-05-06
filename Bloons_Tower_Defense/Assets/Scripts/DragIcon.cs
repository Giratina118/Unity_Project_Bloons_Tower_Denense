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
    bool[,] setTower = null;


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




        Tower2 towclone = GameObject.Instantiate(m_CloneTower);
        towclone.SetSprite(GetComponent<Image>().sprite);

        Vector3 mousepos = Input.mousePosition;
        Vector3 wpos = Camera.main.ScreenToWorldPoint(mousepos);

        wpos.x = Mathf.Floor(wpos.x) + 0.5f;
        wpos.y = Mathf.Floor(wpos.y) + 0.5f;
        wpos.z = -0.1f;
        towclone.transform.position = wpos;


    }

    void Start()
    {
        image = GetComponent<Image>();
        setTower = GetComponent<SetTowerBool>().isAble;
    }

    void Update()
    {

    }

}
