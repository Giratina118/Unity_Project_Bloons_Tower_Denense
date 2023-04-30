using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower2 : MonoBehaviour
{

    protected SpriteRenderer m_LinkRender = null;
    public float attackRange = 2.0f;

    public GameObject copyObj;
    GameObject cloneObj;
    Vector3 attPos;

    CapsuleCollider2D capsuleCollider;


    public void SetSprite( Sprite p_img )
    {
        m_LinkRender.sprite = p_img;

    }

    private void Awake()
    {
        m_LinkRender = GetComponent<SpriteRenderer>();
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "balloon")
        {
            cloneObj = GameObject.Instantiate(copyObj);
            cloneObj.transform.position = attPos;
            cloneObj.SetActive(true);
        }


    }


    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        
    }


    
}
