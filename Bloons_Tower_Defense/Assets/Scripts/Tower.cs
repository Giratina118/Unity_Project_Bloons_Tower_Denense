using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    protected SpriteRenderer m_LinkRender = null;
    public float attRange = 2.0f, attDelay = 0.5f;
    public int attDamage = 1;

    public GameObject copyObj;
    public CreatBalloon creatBalloon;
    public GameObject targetBallon;

    float attackTimer = 0.0f;

    public void SetSprite(Sprite p_img)
    {
        m_LinkRender.sprite = p_img;

    }

    private void Awake()
    {
        m_LinkRender = GetComponent<SpriteRenderer>();
    }

    private void SelectTarget()
    {

        float targetLength = attRange;
        for (int i = 0; i < creatBalloon.balloonsList.Count; i++)
        {
            float distance = Vector3.Distance(creatBalloon.balloonsList[i].transform.position, transform.position);

            if (distance <= attRange)
            {
                targetLength = distance;
                targetBallon = creatBalloon.balloonsList[i].gameObject;
                AttCreate();
                attackTimer = 0.0f;
                break;
            }

        }
    }


    void AttCreate()
    {
        GameObject cloneObj = GameObject.Instantiate(copyObj);
        cloneObj.SetActive(true);
        cloneObj.transform.position = this.transform.position;
        cloneObj.GetComponent<TowerAttack>().TargetSet(targetBallon);
        cloneObj.GetComponent<TowerAttack>().SetDamage(attDamage);
    }



    void Start()
    {
        attackTimer = attDelay;
    }

    void Update()
    {
        attackTimer += Time.deltaTime;
        if (attackTimer >= attDelay)
            SelectTarget();

    }



}
