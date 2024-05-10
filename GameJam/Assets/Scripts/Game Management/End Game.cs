using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Sanity.myEvent += EndTheGame;
    }

    private void EndTheGame()
    {
        SceneManager.LoadScene("Game Over");
    }
}
