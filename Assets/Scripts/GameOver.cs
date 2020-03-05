using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOver : MonoBehaviour {

    public Text scorefinal;
 

    void Awake()
    {
        scorefinal.text = "SCORE :" + PlayerPrefs.GetInt("finalscore");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void Quite()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }


}
