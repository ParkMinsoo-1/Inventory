using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip
{
    public ItemData itemData;
    public EquipType equipType;


    public Equip(ItemData data)
    {
        itemData = data;
        equipType = data.equipTypes;
    }
}

public class Equipment : MonoBehaviour
{
    public Equip equip;
    public Player player;
    public List<Equip> equips = new List<Equip>();

    void Start()
    {
        player = FindObjectOfType<Player>();
    }
    public void Equip(ItemData data)
    {
        // 기존에 같은 타입의 장비가 있다면 해제
        Equip existingEquip = equips.Find(e => e.equipType == data.equipTypes);
        if (existingEquip != null)
        {
            UnEquip(existingEquip.itemData);
        }
        // 새 장비 생성 및 착용
        Equip newEquip = new Equip(data);
        equips.Add(newEquip);
        Debug.Log($"{data.itemName} 추가");

    }

    public void UnEquip(ItemData data)
    {
        Equip equipToRemove = equips.Find(e => e.itemData == data);
        if (equipToRemove != null)
        {
            equips.Remove(equipToRemove);
        }
    }
}
