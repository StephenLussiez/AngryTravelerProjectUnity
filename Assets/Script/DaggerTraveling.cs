using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerTraveling : MonoBehaviour
{
    private GameObject player;
    private GameObject enemy;
    public int dps;
    private Rigidbody2D projectile;
    public GameObject bullet;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        projectile = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        if (enemy == null) return;
        Vector3 direction = enemy.transform.position - transform.position;
        projectile.velocity = new Vector2(direction.x, direction.y).normalized * speed;

    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (enemy == col.transform.gameObject)
        {
            Destroy(bullet);
        }
    }
}
