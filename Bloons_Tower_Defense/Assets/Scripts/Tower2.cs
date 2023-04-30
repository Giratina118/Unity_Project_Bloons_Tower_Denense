using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Tower2 : MonoBehaviour
{
    protected SpriteRenderer m_LinkRender = null;
    public float attackRange = 2.0f;
    public int attDmg = 1;
    public int attDelay = 1000;

    public GameObject copyObj;
    GameObject cloneObj;
    Vector3 attPos;

    CircleCollider2D circleCollider;
    public GameObject targetBallon;


    public void SetSprite( Sprite p_img )
    {
        m_LinkRender.sprite = p_img;

    }

    private void Awake()
    {
        m_LinkRender = GetComponent<SpriteRenderer>();
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("¡¢√À");
        if (other.tag == "Balloon")
        {
            targetBallon = other.gameObject;
            cloneObj = GameObject.Instantiate(copyObj);
            cloneObj.transform.position = attPos;
            cloneObj.SetActive(true);
            Thread.Sleep(attDelay);
        }
    }


    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        circleCollider.radius = attackRange;
    }

    void Update()
    {
        
    }


    
}
