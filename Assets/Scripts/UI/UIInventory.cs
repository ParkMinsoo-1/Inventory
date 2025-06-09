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

    void Start()
    {
        SetInventoryUI(10);
        UpdateInventoryUI(GameManager.Instance.player.inventory);
    }

    public void SetInventoryUI(int slotCount)
    {
        for (int i = 0; i < slotCount; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotParent);
            newSlot.SetItem(null); // 초기엔 빈 슬롯
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
            }
            
            else
                slotList[i].SetItem(null);
        }
        
        inventoryCounts.text = $"{itemCount} / {slotList.Count}";
    }
}
