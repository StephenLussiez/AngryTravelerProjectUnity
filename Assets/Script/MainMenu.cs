using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject panel;
    private PauseManager pauseManager;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panel.activeInHierarchy == false)
            {
                OpenMenu();
            }
            else
            {
                CloseMenu();
            }
        }
    }

    public void CloseMenu()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OpenMenu()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
    }
}
