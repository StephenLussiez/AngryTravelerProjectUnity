using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyGroundController : MonoBehaviour
{
    private GameObject player;
    private GameObject enemy;
    private EnemyController targetEnemy;
    public int dps;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        dps = 5;

    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindWithTag("Enemy");
        transform.position = new Vector3 (player.transform.position.x + offset.x, player.transform.position.y + offset.y, offset.z);
    }
    
        
        
        
    
}
