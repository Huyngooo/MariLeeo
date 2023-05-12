using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    private GameObject help;
    public void GameHelpBtton()
    {
        help.SetActive(true);
        Time.timeScale = 0f;
    }
    public void BackButton()
    {
        help.SetActive(false);
        Time.timeScale = 1f;
    }

public void PlayerGame()
    {
        Application.LoadLevel("lever1");
    }
    public void QuitGamebutton()
    {
        Application.Quit();
    }
}
