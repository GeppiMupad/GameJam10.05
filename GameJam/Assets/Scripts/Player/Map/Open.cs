using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    [SerializeField] private GameObject mapObject;


    public void OnClick()
    {
        mapObject.SetActive(true);
    }
}
