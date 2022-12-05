using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpgradePanelManager : MonoBehaviour
{
    public GameObject panel;
    public GameObject gameManager;
    public UpgradeData upgradeData;

    public void Start()
    {
        upgradeData = gameManager.GetComponent<UpgradeData>();
        upgradeData.RandomUpdateStart();
        upgradeData.GetUpgradeStartText1();
        upgradeData.GetUpgradeStartText2();
        panel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OpenPanel()
    {
        upgradeData = gameManager.GetComponent<UpgradeData>();
        upgradeData.RandomUpdate();
        upgradeData.GetUpgradeText1();
        upgradeData.GetUpgradeText2();
        panel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    
}
