using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    [SerializeField] private UIMain MainUI;
    public UIMain mainUI => MainUI;
   
    [SerializeField] private UIInventory InventoryUI;
    public UIInventory inventoryUI => InventoryUI;
    
    [SerializeField] private UIStatus StatusUI;
    public UIStatus statusUI => StatusUI;


    
    public static UIManager instance;
   
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SetUI()
    {
        mainUI.gameObject.SetActive(true);
        statusUI.gameObject.SetActive(false);
        inventoryUI.gameObject.SetActive(false);
    }

    public void OpenUI(GameObject ui)
    {
        ui.SetActive(true);
    }
    
    public void CloseUI(GameObject ui)
    {
        ui.SetActive(false);
    }

    
    
}
