using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpgradeData : MonoBehaviour
{
    public GameObject panel;
    public int upgrade1;
    public int upgrade2;
    private Attack attackInfo;
    private HolyGroundController holyGroundController;
    private ShurikenController shurikenController;
    private DaggerTraveling daggerTraveling;
    private GameObject player;
    public GameObject shuriken;
    private GameObject holyGround;
    public GameObject projectile;
    public TMPro.TextMeshProUGUI upgrade1Text;
    public TMPro.TextMeshProUGUI upgrade2Text;
    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        attackInfo = player.GetComponent<Attack>();
    }

    public void GetUpgrade1()
    {
        holyGround = GameObject.FindGameObjectWithTag("HolyGround");
        if (upgrade1 == 1)
        {
            if (!attackInfo.projectileAllowed)
            {
                attackInfo.projectileAllowed = true;
                
            }
            else if (attackInfo.fireRate >= 0.1f)
            {
                attackInfo.fireRate -= 0.02f;
            }
        }
        else if (upgrade1 == 2)
        {
            if (!attackInfo.shurikenAllowed)
            {
                attackInfo.shurikenAllowed = true;
            }
            else
            {
                attackInfo.shurikenNumber += 1;
            }
        }
        else if (upgrade1 == 3)
        {
            if (!attackInfo.holyGroundAllowed)
            {
                attackInfo.holyGroundAllowed = true;
            }
            else if (attackInfo.holyGroundAllowed)
            {
                holyGroundController = holyGround.GetComponent<HolyGroundController>();
                holyGroundController.dps += 1;
            }
        }
        else if (upgrade1 == 4)
        {
            if (!attackInfo.shurikenAllowed)
            {
                attackInfo.shurikenAllowed = true;
            }
            else
            {
                attackInfo.shurikenNumber += 1;
            }
        }
        else if (upgrade1 == 5)
        {
            if (!attackInfo.projectileAllowed)
            {
                attackInfo.projectileAllowed = true;
            }
            else if (attackInfo.fireRate >= 0.1f)
            {
                attackInfo.fireRate -= 0.02f;
            }

        }
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GetUpgrade2()
    {
        projectile = GameObject.FindGameObjectWithTag("Projectile");
        shuriken = GameObject.FindGameObjectWithTag("Shuriken");
        holyGround = GameObject.FindGameObjectWithTag("HolyGround");
        if (upgrade2 == 1)
        {
            if (!attackInfo.projectileAllowed)
            {
                attackInfo.projectileAllowed = true;
            }
            else if (attackInfo.fireRate >= 0.1f)
            {
                attackInfo.fireRate -= 0.02f;
            }
        }
        else if (upgrade2 == 2)
        {
            if (!attackInfo.shurikenAllowed)
            {
                attackInfo.shurikenAllowed = true;
            }
            else
            {
                attackInfo.shurikenNumber += 1;
            }
        }
        else if (upgrade2 == 3)
        {
            if (!attackInfo.holyGroundAllowed)
            {
                attackInfo.holyGroundAllowed = true;
            }
            else if (attackInfo.holyGroundAllowed)
            {
                holyGroundController = holyGround.GetComponent<HolyGroundController>();
                holyGroundController.dps += 1;
            }
        }
        else if (upgrade2 == 4)
        {
            if (!attackInfo.shurikenAllowed)
            {
                attackInfo.shurikenAllowed = true;
            }
            else
            {
                attackInfo.shurikenNumber += 1;
            }
        }
        else if (upgrade2 == 5)
        {
            if (!attackInfo.projectileAllowed)
            {
                attackInfo.projectileAllowed = true;
            }
            else if (attackInfo.fireRate >= 0.1f)
            {
                attackInfo.fireRate -= 0.02f;
            }
            
        }
        panel.SetActive(false);
        Time.timeScale = 1f;
    }
    
    public void GetUpgradeStart1()
    {
        if (upgrade1 == 1)
        {
            attackInfo.projectileAllowed = true;
        }
        else if (upgrade1 == 2)
        {
            attackInfo.shurikenAllowed = true;
        }
        else if (upgrade1 == 3)
        {
            attackInfo.holyGroundAllowed = true;
        }
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GetUpgradeStart2()
    {
        if (upgrade2 == 1)
        {
            attackInfo.projectileAllowed = true;
        }
        else if (upgrade2 == 2)
        {
            attackInfo.shurikenAllowed = true;
        }
        else if (upgrade2 == 3)
        {
            attackInfo.holyGroundAllowed = true;
        }
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RandomUpdate()
    {
        upgrade1 = Random.Range(1, 6);
        upgrade2 = Random.Range(1, 6);
        while (upgrade2 == upgrade1)
        {
            upgrade2 = Random.Range(1, 6);
        }
    }

    public void RandomUpdateStart()
    {
        upgrade1 = Random.Range(1, 4);
        upgrade2 = Random.Range(1, 4);
        while (upgrade2 == upgrade1)
        {
            upgrade2 = Random.Range(1, 4);
        }
    }
    
    public void GetUpgradeText1()
    {
        if (upgrade1 == 1)
        {
            if (!attackInfo.projectileAllowed)
            {
                upgrade1Text.text = "Débloquer la balle";
            }
            else if (attackInfo.fireRate >= 0.1f)
            {
                upgrade1Text.text = "Augmente la cadence de tir";
            }
        }
        else if (upgrade1 == 2)
        {
            if (!attackInfo.shurikenAllowed)
            {
                upgrade1Text.text = "Débloquer le Shuriken";
            }
            else
            {
                upgrade1Text.text = "Augmente le nombre de Shuriken";
            }
        }
        else if (upgrade1 == 3)
        {
            if (!attackInfo.holyGroundAllowed)
            {
                upgrade1Text.text = "Débloquer la Zone Sainte";
            }
            else if (attackInfo.holyGroundAllowed)
            {
                upgrade1Text.text = "Augmente les dégâts de la Zone Sainte";
            }
        }
        else if (upgrade1 == 4)
        {
            if (!attackInfo.shurikenAllowed)
            {
                upgrade1Text.text = "Débloquer le Shuriken";
            }
            else
            {
                upgrade1Text.text = "Augmente le nombre de Shuriken";
            }
            
        }
        else if (upgrade1 == 5)
        {
            if (!attackInfo.projectileAllowed)
            {
                upgrade1Text.text = "Débloquer la balle";
            }
            else if (attackInfo.fireRate >= 0.1f)
            {
                upgrade1Text.text = "Augmente la cadence de tir";
            }

        }
    }

    public void GetUpgradeText2()
    {
        if (upgrade2 == 1)
        {
            if (!attackInfo.projectileAllowed)
            {
                upgrade2Text.text = "Débloquer la balle";
            }
            else if (attackInfo.fireRate >= 0.1f)
            {
                upgrade2Text.text = "Augmente la cadence de tir";
            }
        }
        else if (upgrade2 == 2)
        {
            if (!attackInfo.shurikenAllowed)
            {
                upgrade2Text.text = "Débloquer le Shuriken";
            }
            else
            {
                upgrade2Text.text = "Augmente le nombre de Shuriken";
            }
        }
        else if (upgrade2 == 3)
        {
            if (!attackInfo.holyGroundAllowed)
            {
                upgrade2Text.text = "Débloquer la Zone Sainte";
            }
            else if (attackInfo.holyGroundAllowed)
            {
                upgrade2Text.text = "Augmente les dégâts de la Zone Sainte";
            }
        }
        else if (upgrade2 == 4)
        {
            if (!attackInfo.shurikenAllowed)
            {
                upgrade2Text.text = "Débloquer le Shuriken";
            }
            else
            {
                upgrade2Text.text = "Augmente le nombre de Shuriken";
            }
        }
        else if (upgrade2 == 5)
        {
            if (!attackInfo.projectileAllowed)
            {
                upgrade2Text.text = "Débloquer la balle";
            }
            else if (attackInfo.fireRate >= 0.1f)
            {
                upgrade2Text.text = "Augmente la cadence de tir";
            }
        }
    }
    
    public void GetUpgradeStartText1()
    {
        if (upgrade1 == 1)
        {
            upgrade1Text.text = "Débloquer la balle";
        }
        else if (upgrade1 == 2)
        {
            upgrade1Text.text = "Débloquer le Shuriken";
        }
        else if (upgrade1 == 3)
        {
            upgrade1Text.text = "Débloquer la Zone Sainte";
        }
    }

    public void GetUpgradeStartText2()
    {
        if (upgrade2 == 1)
        {
            upgrade2Text.text = "Débloquer la balle";
        }
        else if (upgrade2 == 2)
        {
            upgrade2Text.text = "Débloquer le Shuriken";
        }
        else if (upgrade2 == 3)
        {
            upgrade2Text.text = "Débloquer la Zone Sainte";
        }
    }
}
