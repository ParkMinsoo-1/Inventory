using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;
    [SerializeField] private Text itemCountText;
    [SerializeField] private Image backGround;

    private ItemData itemData;
    public int quantity;

    public void SetItem(ItemData item)
    {
        itemData = item;
        RefreshUI();
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
}
