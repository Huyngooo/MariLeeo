using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour {

    public static GamePause instance;
     void Awake()
    {
        MakeInstance();
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    [SerializeField]
    private GameObject PausePanal,GameOverPanal, Notification , endgame1;
    public void PauseGameButton()
    {
        PausePanal.SetActive(true);
        Time.timeScale = 0f;

    }
    public void ResumeButton()
    {
        PausePanal.SetActive(false);
        Time.timeScale = 1f;
    }
    public void OptionButton()
    {
        Application.LoadLevel("menu");

    }
    public void RestartButton()
    {

        GameOverPanal.SetActive(true);
        
        Application.LoadLevel("lever1");
        Time.timeScale = 1f;
    }
    public void CharterDiedShowPanal()
    {
        GameOverPanal.SetActive(true);
    }
    public void Notication()
    {
        Notification.SetActive(true);
    }

    public void ResumeNotication()
    {
        Notification.SetActive(false);
        Time.timeScale = 1f;
    }
    public void game1()
    {
        endgame1.SetActive(true);
      
    }
    public void btnnextgame1()
    {
        Application.LoadLevel("lever2");
        Time.timeScale = 1f;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
     if(target.tag == "Player")
        {
            Destroy(target.gameObject);
        }
    }
    

}

