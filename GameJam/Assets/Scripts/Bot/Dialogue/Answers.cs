using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Answers : MonoBehaviour
{
    public static event Action myEvent; // opens manageQuestions in Start Convo

    [SerializeField] private GameObject continueObject;

    [SerializeField] private string welcomeText;
    [SerializeField] private string lastText;
    [SerializeField] private string[] answersA = new string[3];  // what can the Bot say
    [SerializeField] private TextMeshProUGUI myText;   // the text that prints the answers;
    [SerializeField] private int letterPerSeconds; // how fast is the Text animations

    public static int buttonIndex = 0; // index which button ( question ) got pressed


    public static bool repeat = false;  // if true -> Bot says his beginning sentence again

    private bool sayLastLine = false;


    //[SerializeField] private ItemContainer myContiner;

    void Start()
    {
        repeat = false;
        StartCoroutine(Dialogue(welcomeText));
        Questions.myEvent += CloseContinue;
    }

    void Update()
    {

        if (repeat == true)
        {
            repeat = false;
            StartCoroutine(Dialogue(welcomeText));
        }

        if (buttonIndex == 1)
        {
            buttonIndex = 0;
            StartCoroutine(Dialogue(answersA[0]));
        }

        if (buttonIndex == 2)
        {
            buttonIndex = 0;
            StartCoroutine(Dialogue(answersA[1]));
        }

        if (buttonIndex == 3)
        {
            buttonIndex = 0;
            StartCoroutine(Dialogue(answersA[2]));
        }

        if (buttonIndex == 4)
        {
            sayLastLine = true;
            buttonIndex = 0;
            StartCoroutine(Dialogue(lastText));
        }
    }

    private void CloseContinue()
    {
        continueObject.SetActive(false);
    }

    public IEnumerator Dialogue(string dialogue)
    {

        myText.text = "";
        foreach (var letter in dialogue.ToCharArray())
        {
            myText.text += letter;
            yield return new WaitForSeconds(2f / letterPerSeconds);
        }

        if (sayLastLine == false)
        {
            myEvent?.Invoke();
        }
        else if (sayLastLine == true)
        {
            sayLastLine = false;
            continueObject.SetActive(true);
        }


    }
}
