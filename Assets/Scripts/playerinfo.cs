using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class playerinfo : MonoBehaviour {

    public GameObject player;
    int health = 100;
    int damageCount = 0;
    int currentHealt;
   // bool playerFigthing;
    public Text helthbar;
    //float healtTimer = 0.0f;
    //bool healthShouldRespawn = false;
    public GameObject healthBottle;
    Vector3 spawnPoint;

    private int count;
    public Text countText;
    public Text winText;

   
    public AudioClip Bleep;
    public AudioClip Cartootpop;


    void Start() {


        currentHealt = health;
        GameObject spawnObject = GameObject.FindGameObjectWithTag("Spawn");
        spawnPoint = spawnObject.transform.position;

        SetCountText();
        winText.text = "";
        
        count = 0;

    }
    // Update is called once per frame
    void Update () {

        helthbar.text = "HEALTH " + currentHealt + " / 100";

    }

    public void Applydamage(int damage)
    {
        damageCount = damageCount + damage;
        if(damageCount == 100)
        {
            currentHealt = currentHealt - 20;
            helthbar.text = "Health" + currentHealt + " / 100" ;
            damageCount = 0;
        }
        if (currentHealt == 0)
        {
            transform.position = spawnPoint;
            count = count - count;
            SetCountText();
        }
    }

  

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Vida")
        {
            if (currentHealt < 100)
            {
                AudioSource.PlayClipAtPoint(Cartootpop, transform.position);
                currentHealt = currentHealt + 10;
                other.gameObject.SetActive(false);
               // healthShouldRespawn = true;
            }
        }

        if (other.gameObject.CompareTag("Pick Up"))
        {
            AudioSource.PlayClipAtPoint(Bleep, transform.position);
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            
        }
        if (other.gameObject.tag == "A")
        {
            transform.position = spawnPoint;
            count = count - count;
            SetCountText();

        }
    }

    void SetCountText()
    {   
        countText.text = "SCORE: " + count;
        //PlayerPrefs.SetInt("finalscore", count);
        //PlayerPrefs.Save();

        if (count >= 8)
        {
            winText.text = "ALL COLLECTED!";

        }

        if (count >= 9)
        {


            SceneManager.LoadScene("GameOver");
        }

    }
    

}
