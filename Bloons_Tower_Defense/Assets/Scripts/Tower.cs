using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    protected SpriteRenderer m_LinkRender = null;
    public float attRange = 2.0f, attDelay = 0.5f;
    public int attDamage = 1, towerAbility = 0;

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
        
        switch (towerAbility)
        {
            case 1:
                Vector3 direction = Vector3.right; // 1, 0, 0
                float div = 45;
                for (int i = 0; i < 8; i++)
                {
                    GameObject cloneObj1 = GameObject.Instantiate(copyObj);
                    cloneObj1.SetActive(true);
                    cloneObj1.transform.position = this.transform.position;
                    cloneObj1.GetComponent<TowerAttack>().SetDamage(attDamage);

                    Vector3 dir = Quaternion.Euler(0, 0, i * div) * direction;
                    cloneObj1.GetComponent<TowerAttack>().SetDirection( dir );
                    cloneObj1.GetComponent<TowerAttack>().SetAttackRange(attRange);
                }
                break;
            default:
                GameObject cloneObj = GameObject.Instantiate(copyObj);
                cloneObj.SetActive(true);
                cloneObj.transform.position = this.transform.position;
                cloneObj.GetComponent<TowerAttack>().TargetSet(targetBallon);
                cloneObj.GetComponent<TowerAttack>().SetDamage(attDamage);
                cloneObj.GetComponent<TowerAttack>().SetTowerAbility(towerAbility);
                break;
        }

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
