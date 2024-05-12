using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WishingWell : MonoBehaviour
{

    [SerializeField] private GameObject eObject;

    [SerializeField] private GameObject wishingObject;
    [SerializeField] private string wishingWellText;
    [SerializeField] private TextMeshProUGUI myText;   // the text that prints the answers;
    [SerializeField] private int letterPerSeconds; // how fast is the Text animations


    [SerializeField] private ItemContainer myContainer;

    private bool isTalking = false;  // is Player already talking 
    private bool canTalk = false; // is player in Range to talk
   
    

  
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isTalking == false && myContainer.itemThree == false && canTalk == true)
        {
            wishingObject.SetActive(true);
            isTalking = true;
            StartCoroutine(Dialogue(wishingWellText));
        }

        if(Input.GetKeyDown(KeyCode.E)  && myContainer.itemThree == true && canTalk == true)
        {
            SceneManager.LoadScene("Sewerage");
        }
    }


    public IEnumerator Dialogue(string dialogue)
    {

        myText.text = "";
        foreach (var letter in dialogue.ToCharArray())
        {
            myText.text += letter;
            yield return new WaitForSeconds(2f / letterPerSeconds);
        }

        isTalking = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            eObject.SetActive(true);
            canTalk = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            eObject.SetActive(false);
            canTalk = false;
        }
    }
}
