using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card
{
    public string name;
    public int value;
    // Add other properties as needed

    public Card(string name, int value)
    {
        this.name = name;
        this.value = value;
    }
}