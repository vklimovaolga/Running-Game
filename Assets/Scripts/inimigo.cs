﻿using UnityEngine;
using System.Collections;

public class inimigo : MonoBehaviour {

    public float fpsTargetDistance;
    public float enemyLookDistance;
    public float attackDistance;
    public float enemyMovementSpeed;
    public float damping;
    public Transform fpsTarget;
    Rigidbody theRigidboody;
    Renderer myRender;

	void Start () {
        myRender = GetComponent<Renderer>();
        theRigidboody = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        fpsTargetDistance = Vector3.Distance(fpsTarget.position, transform.position);
        if (fpsTargetDistance < enemyLookDistance)
        {
            myRender.material.color = Color.yellow;
            lookAtPlayer();
           // print("look at the player");
        }
        if (fpsTargetDistance < attackDistance)
        {
            myRender.material.color = Color.red;
            attackPlease();
           // print("ATACK!");
        }
        else
        {
            myRender.material.color = Color.blue;
        }

    }
    void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(fpsTarget.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
    }

   void attackPlease()
    {
        theRigidboody.AddForce(transform.forward * enemyMovementSpeed);
    }
}
