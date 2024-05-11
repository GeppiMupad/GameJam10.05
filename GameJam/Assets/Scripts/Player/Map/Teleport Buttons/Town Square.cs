using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TownSquare : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Town Square");
    }
}
