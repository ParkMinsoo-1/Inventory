using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    Consumable,
    Equipable,
    Etc
}

public enum EquipType
{
    None,
    Weapon,
    Amor,
    Helmet,
    Boots
}


[CreateAssetMenu(fileName = "New Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")] 
    public string itemName;
    public string itemDescription;
    public ItemType type;
    public Sprite icon;
    public GameObject prefab;
    
    [Header("Consumable")]
    public int healValue;
    
    [Header("Stacking")]
    public bool canStack;
    public int maxStack;
    
    [Header("EquipType")]
    public EquipType equipTypes;
    
    [Header("EquipValue")]
    public int equipAttack;
    public int equipDefense;
    public int equipHealth;
    public int equipCritical;

}
