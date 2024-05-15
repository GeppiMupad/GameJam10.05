using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closedasscheißscripts : MonoBehaviour
{
    [SerializeField] private GameObject jo;


    public static bool canClose = false;

    public static bool open = false;

    private void Update()
    {
        if(open == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                open = false;
                jo.SetActive(false);
            }
            
        }
    }
}
