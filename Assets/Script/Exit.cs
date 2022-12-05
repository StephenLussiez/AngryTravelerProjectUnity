using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{
    public Button yourButton;

    void Start () {
        Button quit = yourButton.GetComponent<Button>();
        quit.onClick.AddListener(QuitOnClick);
    }
    
    void QuitOnClick()
    {
        Application.Quit();
    }
}
