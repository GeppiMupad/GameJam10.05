using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    [SerializeField] private GameObject interactObject;  // E pops up if player is in range
    [SerializeField] private GameObject showObject;  // Image that pops up to see the Item


    private bool inRange = false;

    private void Update()
    {
        
        if(inRange == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                showObject.SetActive(true);
                closedasscheiﬂscripts.open = true;
                Movement.isFrozen = true;
            }

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            interactObject.SetActive(true);
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            interactObject.SetActive(false);
            inRange = false;
        }
    }

}
