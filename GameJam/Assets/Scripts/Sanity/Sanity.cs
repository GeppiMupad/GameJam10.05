using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Sanity : MonoBehaviour
{
    public static event Action myEvent;

    [SerializeField] private Image myImage; // Fill bar that represents Sanity status
    [SerializeField] private Image myImageTwo; // Fill bar that represents Sanity status
    void Start()
    {
        myImage.color = Color.cyan;
        myImageTwo.color = Color.cyan;
        Pills.getSanity += GetSanity;
        Patrol.loseSanity += LoseSanity;
    }


    /// <summary>
    /// Adds to Image Fillamlunt 0.2f for each pill the player collects. The Color of the bar changes by the fill amount 
    /// </summary>
    private void GetSanity()
    {
        myImage.fillAmount += 0.2f;
        myImageTwo.fillAmount += 0.2f;

        if (myImage.fillAmount <= 1f && myImage.fillAmount >= 0.4f)
        {
            myImage.color = new Color(255, 255, 0); // change color to yellow
            myImageTwo.color = new Color(255, 255, 0);
        }

        if(myImage.fillAmount >= 1f)
        {
            myImage.color = Color.cyan;
            myImageTwo.color = Color.cyan;
        }
    }


    /// <summary>
    /// Removes to Image Fillamout 0.2f for each damage he takes. Changes the Color, depending on current Fill amount
    /// </summary>
    private void LoseSanity()
    {
        myImage.fillAmount -= 0.2f;
        myImageTwo.fillAmount -= 0.2f;

        if (myImage.fillAmount <= 0f || myImage.fillAmount <= 0.01f)
        {
            myEvent?.Invoke(); // end the game in End Game script
        }

        if(myImage.fillAmount <= 1f && myImage.fillAmount >= 0.41f)
        {
            myImage.color = new Color(255, 255, 0); // change color to yellow
            myImageTwo.color = new Color(255, 255, 0);
        }

        if (myImage.fillAmount <= 0.4f)
        {
            myImage.color = new Color(255, 0, 0); // change color to red
            myImageTwo.color = new Color(255, 0, 0);
        } 
    }
    


}
