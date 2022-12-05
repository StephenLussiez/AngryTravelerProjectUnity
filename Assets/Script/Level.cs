using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public int level = 1;
    private int experience = 0;
    public GameObject xpBar;
    public ExperienceBar experienceBar;
    public UpgradePanelManager upgradePanel;

    int TO_LEVEL_UP
    {
        get
        {
            return level * 10;
        }
    }

    private void Start()
    {
        experienceBar.UpdateExperienceSlider(experience, TO_LEVEL_UP);
        experienceBar.SetLevelText(level);
    }

    public void AddExperience(int amount)
    {
        experience += amount;
        CheckLevelUp();
        experienceBar.UpdateExperienceSlider(experience, TO_LEVEL_UP);
    }

    public void CheckLevelUp()
    {
        if (experience >= TO_LEVEL_UP)
        {
            experience -= TO_LEVEL_UP;
            level += 1;
            upgradePanel.OpenPanel();
            experienceBar.SetLevelText(level);
        }
    }
}
