using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIInventory : MonoBehaviour
{
    [SerializeField] private UISlot slotPrefab;
    [SerializeField] private Transform slotParent;
    [SerializeField] private Text inventoryCounts;
    private List<UISlot> slotList = new List<UISlot>();

    public GameObject equipButton;
    public GameObject unequipButton;
    public GameObject useButton;
    public GameObject description;
    public Text itemNameText;
    public Text itemDescriptionText;
    public Text itemValueText;

    public UISlot selectedSlot;
    public int selectedItem;

    void Start()
    {
        SetInventoryUI(50);
        UpdateInventoryUI(GameManager.Instance.player.inventory);
        
        equipButton.SetActive(false);
        unequipButton.SetActive(false);
        useButton.SetActive(false);
        description.SetActive(false);
    }

    public void SetInventoryUI(int slotCount)
    {
        for (int i = 0; i < slotCount; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotParent);
            newSlot.SetItem(null); // 초기엔 빈 슬롯
            newSlot.inventory = this;
            newSlot.index = i; // 아이템 슬롯에 인덱스 추가
            slotList.Add(newSlot);
        }
        
    }
    
    public void UpdateInventoryUI(List<ItemData> items)
    {
        int itemCount = 0;
        
        for (int i = 0; i < slotList.Count; i++)
        {
            if (i < items.Count && itemCount != null)
            {
                slotList[i].SetItem(items[i]);
                itemCount++;
                Debug.Log($"{slotList[i].name}{slotList[i].index}: {items[i]}"); // 슬롯인덱스에 아이템 있는지 확인용
            }
            
            else
                slotList[i].SetItem(null);
        }
        
        inventoryCounts.text = $"{itemCount} / {slotList.Count}";
        
    }

    public void SelectSlot(int index)
    {
        if (slotList[index].itemData == null) return;

        selectedSlot = slotList[index];
        selectedItem = index;
        
        itemNameText.text = selectedSlot.itemData.name;
        itemDescriptionText.text = selectedSlot.itemData.itemDescription;
        switch (selectedSlot.itemData.type)
        {
            case ItemType.Consumable:
                itemValueText.text = $"회복량 : {selectedSlot.itemData.healValue.ToString()}";
                break;
            case ItemType.Equipable:
                itemValueText.text =
                    $"공격력 : {selectedSlot.itemData.equipAttack.ToString()}\n" +
                    $"방어력 : {selectedSlot.itemData.equipDefense.ToString()}\n" +
                    $"체력 : {selectedSlot.itemData.equipHealth.ToString()}\n" +
                    $"치명타 : {selectedSlot.itemData.equipCritical.ToString()}";
                break;
        }
        
        
        equipButton.SetActive(selectedSlot.itemData.type == ItemType.Equipable);
        unequipButton.SetActive(selectedSlot.itemData.type == ItemType.Equipable);
        useButton.SetActive(selectedSlot.itemData.type == ItemType.Consumable);
        description.SetActive(true);
    }

    public void ClearSelectSlot()
    {
        selectedSlot = null;
        
        equipButton.SetActive(false);
        unequipButton.SetActive(false);
        useButton.SetActive(false);
        description.SetActive(false);
    }
}
