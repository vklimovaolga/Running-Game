using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
              Destroy(other.gameObject);
        Destroy(gameObject);
            //gameController.GameOver();
        }
     
    }
}
