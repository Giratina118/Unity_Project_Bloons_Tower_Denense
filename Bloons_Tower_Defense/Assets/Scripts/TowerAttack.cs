using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
    
    public float attSpeed = 2.0f;
    GameObject targetBalloon;

    public Balloon balloon;
    public Tower2 tower;

    void Start()
    {
        balloon.GetComponent<Balloon>();
        tower.GetComponent<Collider2D>();
    }

    void Update()
    {
        Vector3 targetDir = (tower.targetBallon.transform.position - this.transform.position).normalized;

        transform.Translate(targetDir.x * attSpeed * Time.deltaTime, targetDir.y * attSpeed * Time.deltaTime, 0.0f);

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Balloon")
        {
            Object.Destroy(gameObject);
            
        }
    }
    
}
