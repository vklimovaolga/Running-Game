using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour {

    private Animator anim;
    private CharacterController controller;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0F;
    public float turnSpeed = 60.0f;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20.0f;
    int nrOfAlowedDJumps = 1; 
    int dJumpCounter = 0;
    
    public AudioClip jump;
 

    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = gameObject.GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetKey("up"))
        {
            anim.SetInteger("AnimationPar", 1);
        }
        else
        {
            anim.SetInteger("AnimationPar", 0);
        }

        if (controller.isGrounded)
        {
            moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;
        
        }

        float turn = Input.GetAxis("Horizontal");
        transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
        controller.Move(moveDirection * Time.deltaTime);
        moveDirection.y -= gravity * Time.deltaTime;

        if (Input.GetButtonDown("Jump"))
        {
            if (controller.isGrounded)
            {
                moveDirection.y = jumpSpeed;
                dJumpCounter = 0;
                AudioSource jump = GetComponent<AudioSource>();
                jump.Play();
            }
            if (!controller.isGrounded && dJumpCounter < nrOfAlowedDJumps)
            {
                moveDirection.y = jumpSpeed;
                dJumpCounter++;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    


}
