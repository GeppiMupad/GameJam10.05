using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private ItemContainer myScriptable;

    private void Start()
    {
        myScriptable.itemOne = false;

        myScriptable.itemTwo = false;

        myScriptable.itemThree = false;
    }
}
