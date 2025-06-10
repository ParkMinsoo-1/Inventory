using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{
    [SerializeField] private GameObject ButtonPanel;
    [SerializeField] private Button Status;
    [SerializeField] private Button Inventory;
    [SerializeField] private Button BackButton;
    
    [Header("Player")]
    [SerializeField] private Text nameText;
    [SerializeField] private Text levelText;
    [SerializeField] private Text hpText;
    
    

    private GameObject currentOpenUI = null;

    public void Start()
    {
        Status.onClick.AddListener(() => {OpenStatusUI();});
        Inventory.onClick.AddListener(() => {OpenInventoryUI();});
        BackButton.onClick.AddListener(() =>{CallBackMainUI(); });
    }

    void OpenStatusUI()
    {
        UIManager.instance.OpenUI(UIManager.instance.statusUI.gameObject);
        currentOpenUI = UIManager.instance.statusUI.gameObject;
        
        HideButtonPanel();
        ShowBackButton();
    }

    void OpenInventoryUI()
    {
        UIManager.instance.OpenUI(UIManager.instance.inventoryUI.gameObject);
        currentOpenUI = UIManager.instance.inventoryUI.gameObject;
        //UIManager.instance.inventoryUI.UpdateInventoryUI(GameManager.Instance.player.inventory);
        
        HideButtonPanel();
        ShowBackButton();
    }
    
    public void HideButtonPanel()
    {
        ButtonPanel.SetActive(false);
    }
    
    public void ShowButtonPanel()
    {
        ButtonPanel.SetActive(true);
    }

    
    public void ShowBackButton()
    {
        BackButton.gameObject.SetActive(true);

    }

    public void HideBackButton()
    {
        BackButton.gameObject.SetActive(false);

    }
    
    public void CallBackMainUI()
    {
        if (currentOpenUI != null)
        {
            UIManager.instance.CloseUI(currentOpenUI);
        }
        
        ShowButtonPanel();
        HideBackButton();
        UIManager.instance.inventoryUI.ClearSelectSlot();
    }

    public void SetPlayerUI(Player player)
    {
        nameText.text = GameManager.Instance.player.Name;
        levelText.text = $"LV.{GameManager.Instance.player.Level.ToString()}";
        hpText.text = GameManager.Instance.player.HP.ToString();
    }
    
    
}
