using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWW : MonoBehaviour
{
    [SerializeField] private GameObject canvasObject;
    public void OnClick()
    {
        canvasObject.SetActive(false);
    }
}
