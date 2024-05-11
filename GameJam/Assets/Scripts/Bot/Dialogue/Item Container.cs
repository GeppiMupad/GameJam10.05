using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

[CreateAssetMenu (fileName = "Item Question" , menuName = "ScriptableObjects/ItemQuestionSO", order = 0)]
public class ItemContainer : ScriptableObject
{
    public bool itemOne = false;

    public bool itemTwo = false;

    public bool itemThree = false;
}
