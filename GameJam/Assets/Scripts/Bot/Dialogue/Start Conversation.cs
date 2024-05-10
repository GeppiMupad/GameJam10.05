using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class StartConversation : MonoBehaviour
{
    [SerializeField] private GameObject eObject;   // E Object if player can interact with the bot

    [SerializeField] private GameObject answerObject; // Canvas where Answers get Printed
    [SerializeField] private GameObject questionObject; // Buttons in Canvas where questions shows up


    public static bool closeQuestions = false;
    public static bool exitButton = false;

    private bool thisBot = false;   // Seperates the bots canvas from the other ones 

    

    private void Start()
    {
        Answers.myEvent += ManageQuestions;
    }

    private void Update()
    {
        if(closeQuestions == true && thisBot == true)
        {
            closeQuestions = false;
            questionObject.SetActive(false);
        }


        if(thisBot == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Movement.isFrozen = true;
                answerObject.SetActive(true);
                
            }

            if(exitButton == true)
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
        if(thisBot == true)
        {
            questionObject.SetActive(true);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
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
