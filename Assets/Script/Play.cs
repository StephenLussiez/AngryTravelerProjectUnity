using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button play = yourButton.GetComponent<Button>();
        play.onClick.AddListener(PlayOnClick);
    }

    void PlayOnClick()
    {
        SceneManager.LoadScene(1);
    }
}
