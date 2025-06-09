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
        SetInventoryUI(50);
        UpdateInventoryUI(GameManager.Instance.player.inventory);
    }

    void Update()
    {

    }

    public void SetInventoryUI(int slotCount)
    {
        for (int i = 0; i < slotCount; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotParent);
            newSlot.SetItem(null); // 초기엔 빈 슬롯
            slotList.Add(newSlot);
        }
        inventoryCounts.text = slotCount.ToString();
    }
    
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
