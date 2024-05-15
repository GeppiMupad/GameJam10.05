using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHarbour : MonoBehaviour
{
    [SerializeField] private GameObject mySpawn;
    [SerializeField] private GameObject myPlayer;
    [SerializeField] private GameObject canvas;

    [SerializeField] private GameObject blackScreen;

    public void OnClick()
    {
        myPlayer.transform.position = mySpawn.transform.position;
        canvas.SetActive(false);

        canvas.SetActive(true);
    }
}
