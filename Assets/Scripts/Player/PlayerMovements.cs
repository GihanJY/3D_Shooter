using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private float hInput;
    private float vInput;
    private Vector3 direction;
    private Vector3 velocity;
    private CharacterController controller;
    private bool canJump;
    private float moveSpeed;
    [SerializeField] private float sprintSpeed;
    [SerializeField] private float normalSpeed;
    [SerializeField] private float jumpForce = 5f;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            canJump = true;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprint();
        }
        else
        {
            run();
        }
        move();
        
    }
    private void jump()
    {
        velocity.y = jumpForce;
        canJump = false;
    }
    private void sprint()
    {
        moveSpeed = sprintSpeed;
    }
    private void run()
    {
        moveSpeed = normalSpeed;
    }
    private void move()
    {
        if (controller.isGrounded)
        {
            direction = new Vector3(hInput, 0, vInput).normalized;
            velocity = direction * moveSpeed;
            velocity = transform.transform.TransformDirection(velocity);
            if (canJump)
            {
                jump();
            }
        }
        velocity.y -= 10 * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
