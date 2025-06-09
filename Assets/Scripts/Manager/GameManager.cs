using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public Player player { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            SetPlayer();                   // Player 데이터 세팅
        }
        else
        {
            Destroy(gameObject); // 이미 인스턴스 있으면 자신 삭제
        }
    }

    private void Start()
    {
        if (UIManager.instance != null)
        {
            UIManager.instance.SetUI();
        }
    }


    void SetPlayer()
    {
        player = new Player("Player", 10, 200, 50, 50, 15);
    }
    
    
}
