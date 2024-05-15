using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
    [SerializeField] private int speed;
    [SerializeField] private int sprintSpeed;
    [SerializeField] private float speedLimiter;


    public static bool isFrozen = false;


    private GetInput myInput;  // Input that gives the player ( WASD Movement )
    private Rigidbody2D myRigid;

    private SpriteRenderer myRenderer;

    void Start()
    {
        myInput = GetComponent<GetInput>();
        myRigid = GetComponent<Rigidbody2D>();
        myRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {


        if(isFrozen == false && myInput.isSprinting == false)
        {
            Vector2 direction = transform.right * myInput.movement.x + transform.up * myInput.movement.y;
            myRigid.velocity = direction * speed * speedLimiter;

            if(myInput.movement.x < 0)
            {
                myRenderer.flipX = true;
            }

            if (myInput.movement.x > 0)
            {
                myRenderer.flipX = false;
            }

        }

        if (isFrozen == false && myInput.isSprinting == true)
        {
            Vector2 direction = transform.right * myInput.movement.x + transform.up * myInput.movement.y;
            myRigid.velocity = direction * sprintSpeed * speedLimiter;

            if (myInput.movement.x < 0)
            {
                myRenderer.flipX = true;
            }

            if (myInput.movement.x > 0)
            {
                myRenderer.flipX = false;
            }
        }

        if (isFrozen == true)
        {
            myRigid.constraints = RigidbodyConstraints2D.FreezePosition;
        }

        if (isFrozen == false)
        {
            myRigid.constraints = RigidbodyConstraints2D.None;
            myRigid.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
