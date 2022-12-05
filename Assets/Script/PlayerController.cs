using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject gameManager;
    private EndGame endGameController;
    private int maxLP;
    public int lifePoints;
    public HPController hpBar;
    private bool isHit;
    private float timeDPS;
    private float timeRegen;
    private int dps;
    // Start is called before the first frame update
    void Start()
    {
        endGameController = gameManager.GetComponent<EndGame>();
        lifePoints = 30;
        maxLP = lifePoints;
        timeDPS = 0.5f;
        timeRegen = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (lifePoints <= 0)
        {
            endGameController.GameOver();
        }
        if (isHit)
        {
            if (timeDPS < Time.time)
            {
                lifePoints -= dps;
                
                timeDPS = Time.time + 0.5f;
            }
        }
        if ((timeRegen < Time.time) && (lifePoints < maxLP))
        {
            lifePoints += 1;
            timeRegen += 5;
        }
        hpBar.SetState(lifePoints, maxLP);
    }
    

    public void TakeDamage(int damage, bool hit)
    {
        isHit = hit;
        dps = damage;
        hpBar.SetState(lifePoints, maxLP);
    }

    public void IsNotHit(bool hit)
    {
        isHit = false;
    }
}
