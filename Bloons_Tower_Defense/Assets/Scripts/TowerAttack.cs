using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
    public float attSpeed = 2.0f;

    private GameObject target;
    private Balloon balloon;
    int attDamage;

    void Start()
    {
        
    }

    void Update()
    {
        if (target == null)
        {
            Object.Destroy(gameObject);
        }
        else
        {
            Vector3 targetDir = (target.transform.position - this.transform.position).normalized;
            transform.Translate(targetDir.x * attSpeed * Time.deltaTime, targetDir.y * attSpeed * Time.deltaTime, 0.0f);
        }
    }

    public void TargetSet(GameObject target)
    {
        this.target = target;
    }

    public void SetDamage(int damage)
    {
        attDamage = damage;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Balloon")
        {
            Object.Destroy(gameObject);
            other.GetComponent<Balloon>().balloonHP -= attDamage;
        }
    }
    
}
