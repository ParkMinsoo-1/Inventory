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
        if (GameManager.Instance != null && GameManager.Instance.player != null)
        {
            mainUI.playerUI.SetPlayerUI(GameManager.Instance.player);
        }
        else
        {
            Debug.LogWarning("Player가 아직 생성되지 않았습니다.");
        }
        
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
