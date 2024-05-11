using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static event Action loseSanity;

    [SerializeField] private int speed;
    [SerializeField] private int sprintSpeed;
    [SerializeField] private float speedLimiter;


    public static bool isFrozen = false;


    private GetInput myInput;  // Input that gives the player ( WASD Movement )
    private Rigidbody2D myRigid;

    void Start()
    {
        myInput = GetComponent<GetInput>();
        myRigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(isFrozen == false && myInput.isSprinting == false)
        {
            Vector2 direction = transform.right * myInput.movement.x + transform.up * myInput.movement.y;
            myRigid.velocity = direction * speed * speedLimiter;
            
        }

        if (isFrozen == false && myInput.isSprinting == true)
        {
            Vector2 direction = transform.right * myInput.movement.x + transform.up * myInput.movement.y;
            myRigid.velocity = direction * sprintSpeed * speedLimiter;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            loseSanity?.Invoke();
        }
    }
}
