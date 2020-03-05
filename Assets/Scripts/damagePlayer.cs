using UnityEngine;
using System.Collections;

public class damagePlayer : MonoBehaviour {

    public int playerhealth = 100;
    int damage = 20;
	void Start () {
        print(playerhealth);
	
	}
	

    void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.tag == "enemy")
        {
            playerhealth -= damage;
            print("enemy just touched somthing!! " + playerhealth);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
