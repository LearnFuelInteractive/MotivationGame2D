using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInputManager : MonoBehaviour
{
    public UnityEvent<Vector2> moveEvent;
    public UnityEvent<bool> sprintEvent;
    public UnityEvent startMoving;
    public UnityEvent stopMoving;
    public Animator animator;
    private Vector2 movementInput;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprintEvent.Invoke(true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprintEvent.Invoke(false);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if(movementInput != Vector2.zero) {
            animator.SetFloat("XInput", movementInput.x);
            animator.SetFloat("YInput", movementInput.y);
            animator.SetBool("IsWalking", true);
            startMoving.Invoke();

        } else
        {
            animator.SetBool("IsWalking", false);
            stopMoving.Invoke();
        }


        moveEvent.Invoke(movementInput);
    }
}
