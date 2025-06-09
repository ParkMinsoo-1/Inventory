using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UISlot slotPrefab;
    [SerializeField] private Transform slotParent;
    private List<UISlot> slotList = new List<UISlot>();

    void Start()
    {
        SetInventoryUI();
    }

    private void SetInventoryUI()
    {
        int inventorySize = 30; // 예: 30칸

        for (int i = 0; i < inventorySize; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotParent);
            newSlot.SetItem(null); // 초기엔 빈 슬롯
            slotList.Add(newSlot);
        }
    }

    // 아이템을 인벤토리에 반영하는 메서드도 추가 가능
    public void UpdateInventoryUI(List<ItemData> items)
    {
        for (int i = 0; i < slotList.Count; i++)
        {
            if (i < items.Count)
                slotList[i].SetItem(items[i]);
            else
                slotList[i].SetItem(null);
        }
    }
}
