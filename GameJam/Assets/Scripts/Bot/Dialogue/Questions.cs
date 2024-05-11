using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Questions : MonoBehaviour
{
    public static event Action myEvent;
    public void OnQuestionOne()
    {
        Answers.buttonIndex = 1;
        StartConversation.closeQuestions = true;
    }
    public void OnQuestionTwo()
    {
        Answers.buttonIndex = 2;
        StartConversation.closeQuestions = true;
    }
    public void OnQuestionThree()
    {
        
        Answers.buttonIndex = 3;
        StartConversation.closeQuestions = true;
    }

    public void OnExit()
    {
        Answers.buttonIndex = 4;
        StartConversation.closeQuestions = true;
    }


    public void OnContinue()
    {
        myEvent?.Invoke(); // close continue Object in Answers
        Answers.repeat = true;
        StartConversation.exitButton = true;
    }
}
