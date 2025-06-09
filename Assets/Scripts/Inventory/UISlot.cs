using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;
    [SerializeField] private Text itemCountText;

    private ItemData itemData;

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
            //itemCountText.text = itemData.count.ToString();
        }
        else
        {
            itemIcon.sprite = null;
            itemCountText.text = "";
        }
    }
}
