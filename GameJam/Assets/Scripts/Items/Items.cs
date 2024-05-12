using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    [SerializeField] private int index;

    [SerializeField] private ItemContainer myScriptable;
    [SerializeField] private GameObject canvasObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            canvasObject.SetActive(true);

            if (index == 1)
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

            if (index == 4)
            {
                myScriptable.itemFour = true;
            }

            if (index == 5)
            {
                myScriptable.itemFive = true;
            }
        }
    }
}
