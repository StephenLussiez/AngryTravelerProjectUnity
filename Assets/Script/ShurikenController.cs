using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenController : MonoBehaviour
{
    private GameObject enemy;
    private GameObject player;
    public int dps;
    private Rigidbody2D shuriken;
    public GameObject shurikenObject;
    private int numberHit;
    private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        shuriken = GetComponent<Rigidbody2D>();
        numberHit = 0;
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        shuriken.transform.Rotate(new Vector3(0, 0, 1), 10);
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        if (enemy == null) return;
        Vector3 direction = enemy.transform.position - transform.position;
        shuriken.velocity = new Vector2(direction.x, direction.y).normalized * speed;
        if (numberHit >= 2)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject == enemy)
        {
            numberHit++;
        }
    }
}
