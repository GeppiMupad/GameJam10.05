using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

[CreateAssetMenu (fileName = "Item Question" , menuName = "ScriptableObjects/ItemQuestionSO", order = 0)]
public class ItemContainer : ScriptableObject
{
    public bool itemOne = false; // Fisch Kopf

    public bool itemTwo = false; // Polizei Marke

    public bool itemThree = false; // Münze

    public bool itemFour = false;

    public bool itemFive = false;
}
