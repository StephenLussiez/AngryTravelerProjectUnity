using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject panelVictory;
    public GameObject panelGameOver;

    public void GameOver()
    {
        panelGameOver.SetActive(true);
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (Time.time > 900)
        {
            panelVictory.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
