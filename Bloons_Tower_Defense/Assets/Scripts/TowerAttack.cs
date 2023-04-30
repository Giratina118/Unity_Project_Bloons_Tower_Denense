using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
    public int attDmg = 1;
    public float attSpeed = 2.0f;
    public GameObject targetBalloon;

    public Balloon balloon;


    void Start()
    {
        balloon.GetComponent<Balloon>();
    }

    void Update()
    {
        Vector3 targetDir = (targetBalloon.transform.position - this.transform.position).normalized;

        transform.Translate(targetDir.x * attSpeed * Time.deltaTime, targetDir.y * attSpeed * Time.deltaTime, 0.0f);

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Object.Destroy(gameObject);
        balloon.balloonHP = -attDmg;
        if (balloon.balloonHP <= 0)
        {
            Object.Destroy(other.gameObject);
        }


    }
    
}
