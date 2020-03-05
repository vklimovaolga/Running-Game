using UnityEngine;
using System.Collections;

public class enemy4 : MonoBehaviour
{
    private GameObject player;
    public float speed = 1.0f;
    public playerinfo2 character;

    // Use this for initialization
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

        if (!player)
        {
            Debug.Log("ERROR could not find Player!");
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (!player)
        {
            return;
        }

        var distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance < 50)
        {
            //Debug.Log("player is close");
            var delta = player.transform.position - transform.position;
            delta.Normalize();
            var moveSpeed = speed * Time.deltaTime;
            transform.position = transform.position + (delta * moveSpeed);
            transform.LookAt(player.transform);
            character.Applydamage(1);
            // character.playerInCombat(1);
        }

        else
        {
            //Debug.Log("not close yet " + distance);
            // character.playerInCombat(0);
        }
    }

}
