using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public static event Action loseSanity;

    [SerializeField] private float speed = 1f;
    [SerializeField] private int walkRange = 4;

    private float right;
    private float left;

    private bool arrivedOne = false;

    private bool arrivedTwo = true;

    void Start()
    {
        right = transform.position.y;
        left = transform.position.y - walkRange;
    }


    private void Update()
    {
        if(arrivedOne == false)
        {
            transform.Translate(Vector3.up * speed);

            if (transform.position.y >= right)
            {
                arrivedOne = true;
                arrivedTwo = false;
            }
        }
        
        if(arrivedTwo == false)
        {
            transform.Translate(Vector3.down * speed);

            if (transform.position.y <= left)
            {
                arrivedOne = false;
                arrivedTwo = true;
            }
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            loseSanity?.Invoke();
        }
    }
}
