using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    [SerializeField] private int index;

    [SerializeField] private ItemContainer myScriptable;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

            if(index == 1)
            {
                myScriptable.itemOne = true;
            }


            if (index == 2)
            {
                myScriptable.itemTwo = true;
            }


            if (index == 3)
            {
                myScriptable.itemThree = true;
            }
        }
    }
}
