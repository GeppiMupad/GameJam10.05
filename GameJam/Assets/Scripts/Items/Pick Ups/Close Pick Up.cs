using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePickUp : MonoBehaviour
{
    [SerializeField] private GameObject canvasObject;
    


    public void OnClick()
    {
        canvasObject.SetActive(false);
        Movement.isFrozen = false;
    }
}
