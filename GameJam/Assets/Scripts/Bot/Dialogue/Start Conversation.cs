using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class StartConversation : MonoBehaviour
{
    [SerializeField] private GameObject eObject;   // E Object if player can interact with the bot

    [SerializeField] private GameObject answerObject; // Canvas where Answers get Printed
    [SerializeField] private GameObject questionObject; // Buttons in Canvas where questions shows up
    [SerializeField] private ItemContainer myScriptable; // Scriptable Object with item bool

    [SerializeField] private int questionIndex;

    public static bool closeQuestions = false;
    public static bool exitButton = false;

    private bool thisBot = false;   // Seperates the bots canvas from the other ones 



    private void Start()
    {
        Answers.myEvent += ManageQuestions;
    }

    private void Update()
    {
        if (closeQuestions == true && thisBot == true)
        {
            closeQuestions = false;
            questionObject.SetActive(false);
        }


        if (thisBot == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Movement.isFrozen = true;
                answerObject.SetActive(true);

            }

            if (exitButton == true)
            {
                exitButton = false;
                Movement.isFrozen = false;
                answerObject.SetActive(false);
                questionObject.SetActive(false);
            }
        }
    }


    private void ManageQuestions()
    {
        if (thisBot == true)
        {
            questionObject.SetActive(true);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        Transform temp = questionObject.transform.GetChild(3); // Take the third Question and disable it 
        GameObject childObject = temp.gameObject;


        if(questionIndex == 1)
        {
            if (myScriptable.itemOne == true)
            {
                childObject.SetActive(true);
            }
            else
            {
                childObject.SetActive(false);
            }
        }

        if (questionIndex == 2)
        {
            if (myScriptable.itemTwo == true)
            {
                childObject.SetActive(true);
            }
            else
            {
                childObject.SetActive(false);
            }
        }

        if (questionIndex == 3)
        {
            if (myScriptable.itemThree == true)
            {
                childObject.SetActive(true);
            }
            else
            {
                childObject.SetActive(false);
            }
        }





        if (collision.gameObject.CompareTag("Player"))
        {
            eObject.SetActive(true);
            thisBot = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            eObject.SetActive(false);
            thisBot = false;
        }
    }
}
