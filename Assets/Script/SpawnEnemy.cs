using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnEnemy : MonoBehaviour
{
    public float time ;
    public float spawningRate = 1f;
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    public int i;

    private float lastSpawn = 1f;

    // Update is called once per frame
    void Update()
    {
        i = 0;
        time = Time.time;
        
        if (lastSpawn + spawningRate < Time.time && Time.time < 150)
        {
            Spawn();
            lastSpawn = Time.time;
            spawningRate *= 0.999f;
        }
        else if (lastSpawn + spawningRate < Time.time && Time.time < 300 && Time.time > 150)
        {
            while (i < 2)
            {
                Spawn();
                i++;
            }
            lastSpawn = Time.time;
            spawningRate *= 0.998f;
        }
        else if (lastSpawn + spawningRate < Time.time && Time.time < 600 && Time.time > 300)
        {
            while (i < 4)
            {
                Spawn();
                i++;
            }
            lastSpawn = Time.time;
            spawningRate *= 0.997f;
        }
        else if (lastSpawn + spawningRate < Time.time && Time.time < 780 && Time.time > 600)
        {
            while (i < 8)
            {
                Spawn();
                i++;
            }
            lastSpawn = Time.time;
            spawningRate *= 0.996f;
        }
        else if (lastSpawn + spawningRate < Time.time && Time.time < 840 && Time.time > 780)
        {
            while (i < 16)
            {
                Spawn();
                i++;
            }
            lastSpawn = Time.time;
            spawningRate *= 0.996f;
        }
        else if (lastSpawn + spawningRate < Time.time && Time.time < 900 && Time.time > 840)
        {
            while (i < 24)
            {
                Spawn();
                i++;
            }
            lastSpawn = Time.time;
            spawningRate *= 0.995f;
        }
    }

    void Spawn()
    {
        var randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];
        Instantiate(enemyPrefab, randomSpawnPoint.position, Quaternion.identity);
    }
}
