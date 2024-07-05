using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card
{
    public string name;
    public int value;
    public GameObject prefab; // Add a reference to the card's prefab

    public Card(string name, int value, GameObject prefab)
    {
        this.name = name;
        this.value = value;
        this.prefab = prefab;
    }
}
