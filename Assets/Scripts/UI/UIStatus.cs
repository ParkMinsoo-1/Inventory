using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIStatus : MonoBehaviour
{
    [SerializeField] private Text attackValue;
    [SerializeField] private Text defenseValue;
    [SerializeField] private Text hpValue;
    [SerializeField] private Text criValue;

    public Player player;

    public void SetPlayerStatus(Player player)
    {
        attackValue.text = player.Attack.ToString();
        defenseValue.text = player.Defense.ToString();
        hpValue.text = player.HP.ToString();
        criValue.text = $"{player.Critical.ToString()}%";
    }
}
    
