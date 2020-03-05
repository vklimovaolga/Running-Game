using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class Portal : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Portal")
        {
            SceneManager.LoadScene("lvl 2");
        }


    }
}
