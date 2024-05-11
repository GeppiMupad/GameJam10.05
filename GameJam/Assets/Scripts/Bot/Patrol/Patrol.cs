using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Patrol : MonoBehaviour
{


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



    //private void MoveToPositionTwo()
    //{
    //    if (arrivedOne == false)
    //    {
    //        arrivedTwo = true;
    //        if (transform.position != positionA[0].transform.position)
    //        {
    //            transform.position = Vector3.MoveTowards(transform.position, positionA[0].transform.position, 10f);
    //        }

    //        if (transform.position == positionA[0].transform.position)
    //        {
    //            arrivedOne = true;
    //        }
    //    }


    //    if (arrivedTwo == false)
    //    {
    //        if (transform.position != positionA[1].transform.position)
    //        {
    //            transform.position = Vector3.MoveTowards(transform.position, positionA[1].transform.position, 5f);
    //        }

    //        if (transform.position == positionA[1].transform.position)
    //        {
    //            arrivedOne = false;
    //        }

    //    }

    //    arrivedTwo = false;
    //}

    //private IEnumerator WaitSeconds()
    //{

    //}
}
