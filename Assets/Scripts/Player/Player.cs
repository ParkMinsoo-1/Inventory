using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public float HP { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public float Critical { get; private set; }

    public List<ItemData> inventory;

    public Player(string name, int level, float hp, int attack, int defense, float critical )
    {
        Name = name;
        Level = level;
        HP = hp;
        Attack = attack;
        Defense = defense;
        Critical = critical ;
        inventory = new List<ItemData>();
    }

    public void SetBasicItems(List<ItemData> startingItems)
    {
        inventory.AddRange(startingItems);
    }
}
