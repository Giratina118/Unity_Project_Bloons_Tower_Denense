using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragIcon : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Image image;
    public Tower2 m_CloneTower = null;
    public Image DragingIcon = null;


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
        //DragingIcon.sprite = GetComponent<Image>().sprite;
        DragingIcon.gameObject.SetActive(false);


        Tower2 towclone = GameObject.Instantiate(m_CloneTower);
        towclone.SetSprite( GetComponent<Image>().sprite );


        Vector3 mousepos = Input.mousePosition;
        Vector3 wpos = Camera.main.ScreenToWorldPoint(mousepos);

        wpos.x = Mathf.Round(wpos.x);
        wpos.y = Mathf.Round(wpos.y);
        wpos.z = -0.1f;
        towclone.transform.position = wpos;


    }

    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        
    }
}
