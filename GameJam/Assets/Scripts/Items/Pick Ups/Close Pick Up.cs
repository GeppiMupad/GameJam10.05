using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ClosePickUp : MonoBehaviour
{
    [SerializeField] private GameObject canvasObject;
    [SerializeField] private GameObject destroyObject;


    public void OnClick()
    {
        canvasObject.SetActive(false);
        closedasschei�scripts.canClose = true;
      //  Destroy(destroyObject);
        Movement.isFrozen = false;
    }
}
