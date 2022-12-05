using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private GameObject player;
    private GameObject holyGround;
    private GameObject shuriken;
    private GameObject projectile;
    private HolyGroundController holyGroundtargeting;
    private ShurikenController shurikenTargeting;
    private DaggerTraveling bulletController;
    private Transform targetDestination;
    public Rigidbody2D enemy;
    private PlayerController targetPlayer;
    private float timeDPS;
    private int dps;
    public bool isHit;
    public bool hitPlayer;
    public int hp = 5;
    private int damage = 5;
    public float speed;
    private int experience_reward;
    private float gameTime;
    // Start is called before the first frame update
    void Start()
    {
        experience_reward = 2;
        player = GameObject.FindWithTag("Player");
        speed = 1;
        timeDPS = 0.5f;
        isHit = false;
        hitPlayer = false;
        gameTime = 30;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = (player.transform.position - enemy.transform.position).normalized;
        enemy.velocity = direction * speed;
        holyGround = GameObject.FindWithTag("HolyGround");
        shuriken = GameObject.FindWithTag("Shuriken");
        projectile = GameObject.FindWithTag("Projectile");
        
        if (hp <= 0)
        {
            Destroy(enemy.gameObject);
            player.GetComponent<Level>().AddExperience(experience_reward);
        }
        if (isHit)
        {
            if (timeDPS < Time.time)
            {
                hp -= dps;
                timeDPS = Time.time + 0.5f;
            }
        }

        if (Time.time > gameTime)
        {
            hp += 1;
            gameTime = gameTime + 30;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            Attack();
        }
        if (col.gameObject == shuriken)
        {
            isHit = true;
            shurikenTargeting = shuriken.GetComponent<ShurikenController>();
            dps = shurikenTargeting.dps;
        }
        if (col.gameObject == holyGround)
        {
            isHit = true;
            holyGroundtargeting = holyGround.GetComponent<HolyGroundController>();
            dps = holyGroundtargeting.dps;
        }
        if (col.gameObject == projectile)
        {
            isHit = true;
            bulletController = projectile.GetComponent<DaggerTraveling>();
            dps = bulletController.dps;
            Destroy(bulletController.bullet);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject == holyGround)
        {
            if (isHit)
            {
                isHit = false;
            }
        }

        if (col.gameObject == player)
        {
            if (hitPlayer)
            {
                targetPlayer.IsNotHit(hitPlayer);
            }
        }
    }


    public void Attack()
    {
        if (targetPlayer == null)
        {
            targetPlayer = player.GetComponent<PlayerController>();
        }

        hitPlayer = true;
        targetPlayer.TakeDamage(damage, hitPlayer);
    }
    
    void OnBecameInvisible() {
        Destroy(enemy.gameObject);
    }
}
