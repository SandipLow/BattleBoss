using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text PP;

    public Button PsPl;

    public Camera cam;

    public Color easy;
    public Color medium;
    public Color hard;

    public Image startMenu;

    public Sprite Play;
    public Sprite Pause;

    public BossHealth boss;
    public PlayerHealth player;

    public Image LevelSelect;

    public HealthBar hb;
    public HealthBarPlayer hbp;

    public Image Panel;

    public void Reload()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
	}

    public void PausePlay()
    {
        if(PsPl.GetComponent<Image>().sprite == Pause)
        {
            Time.timeScale = 0;
            PsPl.GetComponent<Image>().sprite = Play;
        }

        else if(PsPl.GetComponent<Image>().sprite == Play)
        {
            Time.timeScale = 1;
            PsPl.GetComponent<Image>().sprite = Pause;
        }
    }

    public void OpenYT()
    {
        Application.OpenURL("https://www.youtube.com/channel/UC6DAOimMnTUCpPQ2_-7RtZg");
    }

    public void nextPage()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    void Start()
    {
        cam.aspect = 6f/3f;
    }

    public void StartGame()
    {
        startMenu.gameObject.SetActive(true);
    }

    public void exit()
    {
        Application.Quit();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Easy()
    {
        boss.health = 1000;
        boss.vul = 400;
        player.health = 200;
        cam.backgroundColor = easy;
        boss.gameObject.SetActive(true);
        player.gameObject.SetActive(true);
        LevelSelect.gameObject.SetActive(false);
        hb.Starter();
        hbp.Starter();
    }

    public void Normal()
    {
        boss.health = 3000;
        boss.vul = 1200;
        player.health = 300;
        cam.backgroundColor = medium;
        boss.gameObject.SetActive(true);
        player.gameObject.SetActive(true);
        LevelSelect.gameObject.SetActive(false);
        hb.Starter();
        hbp.Starter();
    }

    public void Tough()
    {
        boss.health = 5000;
        boss.vul = 2000;
        player.health = 500;
        cam.backgroundColor = hard;
        boss.gameObject.SetActive(true);
        player.gameObject.SetActive(true);
        LevelSelect.gameObject.SetActive(false);
        hb.Starter();
        hbp.Starter();
    }

    public void panelon()
    {
        Panel.gameObject.SetActive(true);
    }

    public void paneloff()
    {
        Panel.gameObject.SetActive(false);
    }
}
