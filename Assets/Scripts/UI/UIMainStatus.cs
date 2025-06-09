using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainStatus : MonoBehaviour
{
    [SerializeField] private Text nameText;
    [SerializeField] private Text levelText;
    [SerializeField] private Text hpText;

    public Player player;

    public void SetPlayerUI(Player player)
    {
        nameText.text = player.Name;
        levelText.text = player.Level.ToString();
        hpText.text = player.HP.ToString();
    }
}
