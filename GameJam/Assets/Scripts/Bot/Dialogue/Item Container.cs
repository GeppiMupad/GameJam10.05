using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Item Question" , menuName = "ScriptableObjects/ItemQuestionSO", order = 0)]
public class ItemContainer : ScriptableObject
{
    public bool itemOne = false; // Fisch Kopf

    public bool itemTwo = false; // Polizei Marke

    public bool itemThree = false; // M�nze

    public bool itemFour = false; // Wahlplakat

    public bool itemFive = false;
}
