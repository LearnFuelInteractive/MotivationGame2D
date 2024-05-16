using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public float sprintSpeed = 10f;
    public bool isSprinting = false;


    public void Start()
    {
       
    }

    public void Update()
    {
    }

    public void Move(Vector2 movementInput)
    {
        if (isSprinting)
        {
            rb.velocity = movementInput * sprintSpeed;
        }
        else
        {
            rb.velocity = movementInput * moveSpeed;
        }
    }

    public void Sprint(bool isPressingRun) // is called when the sprint event is invoked
    {
        this.isSprinting = isPressingRun;
    }
}