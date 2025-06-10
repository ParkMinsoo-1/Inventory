using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Player player { get; private set; }
    [SerializeField] private List<ItemData> basicItems;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            SetData(); // 플레이어와 UI 세팅
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetData()
    {
        GameObject Player = GameObject.FindWithTag("Player");
        player = Player.AddComponent<Player>();
        player.SetPlayerData("Player", 5, 120f, 30, 15, 10);
        player.SetBasicItems(basicItems); // Inspector에서 넣어준 기본 아이템 리스트

    }
}
