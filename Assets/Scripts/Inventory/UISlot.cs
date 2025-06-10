using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public UIInventory inventory;
    
    [SerializeField] private Image itemIcon;
    [SerializeField] private Text itemCountText;
    [SerializeField] private Image backGround;
    public GameObject equipPannel;

    public ItemData itemData;
    public int quantity;

    public int index;

    public void SetItem(ItemData item)
    {
        itemData = item;
        RefreshUI();
        equipPannel.SetActive(false);
    }

    public void RefreshUI()
    {
        if (itemData != null)
        {
            itemIcon.sprite = itemData.icon;
            itemCountText.text = quantity > 1 ? quantity.ToString() : string.Empty;
        }
        else
        {
            itemIcon.sprite = null;
            itemCountText.text = "";
        }
    }

    public void OnClickSlot()
    {
        inventory.SelectSlot(index);
    }

    public void SetEquipPannel()
    {
        equipPannel.SetActive(true);
    }

    public void UnEquipPannel()
    {
        equipPannel.SetActive(false);
    }
}
