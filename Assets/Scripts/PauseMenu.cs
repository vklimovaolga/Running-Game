using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    GameObject PauseMenu1;
    bool paused;
    bool muted;
    [SerializeField]
    Text mutetext;
	void Start () {
        paused = false;
        PauseMenu1 = GameObject.Find("PauseMenu");
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }
        if (paused)
        {
            PauseMenu1.SetActive(true);
            Time.timeScale = 0;

        }
        else if (!paused)
        {
            PauseMenu1.SetActive(false);
            Time.timeScale = 1;
        }
        if (muted)
        {
            AudioListener.volume = 0;
            mutetext.text = "UNMUTE";
        }
        else if (!muted)
        {
            AudioListener.volume = 1;
            mutetext.text = "MUTE";
        }
	
	}
    public void Resume()
    {
        paused = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
    public void Mute()
    {
        muted = !muted;
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
