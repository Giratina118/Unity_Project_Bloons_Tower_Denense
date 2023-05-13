using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
    public float attSpeed = 2.0f;

    protected GameObject target;
    protected Balloon balloon;
    protected int attDamage;
    protected int towerAbility;
    protected float attRange;
    protected float m_Distance = 0f;

    
    

    void Start()
    {
        m_Distance = 0;
    }

    protected virtual void Update()
    {

        if (target != null)
        {
            Vector3 targetDir = (target.transform.position - this.transform.position).normalized;
            transform.Translate(targetDir.x * attSpeed * Time.deltaTime, targetDir.y * attSpeed * Time.deltaTime, 0.0f);
        }
        else if( m_Direction.sqrMagnitude >= 0.0001f)
        {
            transform.position += m_Direction * attSpeed * Time.deltaTime;
            m_Distance += attSpeed * Time.deltaTime;
            if (m_Distance >= attRange)
            {
                GameObject.Destroy(gameObject);
            }
        }
        else
        {
            GameObject.Destroy(gameObject);
        }
    }


    public Vector3 m_Direction = Vector3.zero;
    public void SetDirection(Vector3 p_direction)
    {
        m_Direction = p_direction.normalized;
    }

    public void SetTowerAbility(int towerAbility)
    {
        this.towerAbility = towerAbility;
    }

    public void SetAttackRange(float attRange)
    {
        this.attRange = attRange;
    }

    public void TargetSet(GameObject target)
    {
        this.target = target;
    }

    public void SetDamage(int damage)
    {
        attDamage = damage;
    }



    public float RangeSize = 1f;

    protected void RangeAttackFN(Collider2D other)
    {
        var hitcolliderarr = Physics2D.OverlapCircleAll(this.transform.position, RangeSize);

        foreach (var item in hitcolliderarr)
        {
            if (item.tag == "Balloon" && item != other)
            {
                item.GetComponent<Balloon>().balloonHP -= attDamage / 2;
            }
        }
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Balloon")
        {
            Object.Destroy(gameObject);
            other.GetComponent<Balloon>().balloonHP -= attDamage;

            
            switch (towerAbility)
            {
                case 2:
                    if (other.tag != "Balloon")
                        return;
                    RangeAttackFN(other);
                    break;
                case 3:
                    if (!other.GetComponent<Balloon>().isIceBool)
                    {
                        other.GetComponent<Balloon>().isIceBool = true;
                        other.GetComponent<Balloon>().iceTimer = 0.0f;
                        other.GetComponent<Balloon>().balloonSpeed /= 2;
                    }
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }

        }
    }
    
}
