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

    [SerializeField] private int idex = 0;

    private float right;
    private float left;

    private bool arrivedOne = false;

    private bool arrivedTwo = true;

    private SpriteRenderer mySprite;

    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();

        if(idex == 0)
        {
            right = transform.position.y;
            left = transform.position.y - walkRange;
        }

        if(idex == 1)
        {
            right = transform.position.x;
            left = transform.position.x - walkRange;
        }
        
    }


    private void Update()
    {
        if(idex == 0)
        {
            if (arrivedOne == false)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
               
                if (transform.position.y >= right)
                {
                    arrivedOne = true;
                    arrivedTwo = false;
                }
            }

            if (arrivedTwo == false)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                
                if (transform.position.y <= left)
                {
                    arrivedOne = false;
                    arrivedTwo = true;
                }
            }
        }


        if (idex == 1)
        {
            if (arrivedOne == false)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                mySprite.flipX = false;

                if (transform.position.x <= left)
                {
                    arrivedOne = true;
                    arrivedTwo = false;
                }
            }

            if (arrivedTwo == false)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                mySprite.flipX = true;

                if (transform.position.x >= right)
                {
                    arrivedOne = false;
                    arrivedTwo = true;
                }
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
