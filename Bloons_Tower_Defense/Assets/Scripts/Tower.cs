using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Tower : MonoBehaviour//, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public float attackRange = 2.0f;

    public GameObject copyObj;
    GameObject cloneObj;

    public Camera SceneCamera = null;
    public Vector3 Wpos = new Vector3();
    Vector3 attPos;

    CapsuleCollider2D capsuleCollider;

    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider2D>();
    }


    void Update()
    {
        
        Vector3 mousepos = Input.mousePosition;
        Vector3 wpos = SceneCamera.ScreenToWorldPoint(mousepos);

        Wpos = wpos;

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


    /*
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        image.color = new Color(1f, 1f, 1f, 0.5f);
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        image.color = new Color(1f, 1f, 1f, 1f);
        transform.position = Input.mousePosition;

        attPos = Wpos;
        attPos.z = 0;
    }
    */

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "balloon")
        {
            cloneObj = GameObject.Instantiate(copyObj);
            cloneObj.transform.position = attPos;
            cloneObj.SetActive(true);
        }


    }
}
