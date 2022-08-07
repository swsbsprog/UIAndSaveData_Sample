using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UserDataManager : MonoBehaviour
{
    public TMP_Text goldText;
    UserData userData;
    public UserData UserData
    {
        get
        {
            if (userData == null)
                userData = GetComponent<SaveData>().userData;
            return userData;
        }
    }

    private void UpdateGoldUI()
    {
        //숫자 천단위로 ","표시됨 (예:1,000)
        goldText.text = UserData.gold.ToString("N0"); 
    }

    private void Start() => UpdateGoldUI();
    public void ChangeGold(int changeAmount)
    {
        UserData.gold += changeAmount;
        UpdateGoldUI();
    }

    public void BuyItem(string buyItemName)
    {
        UserData.haveItem.Add(buyItemName);
        ChangeGold(-10);
    }
    public void SellItem(string sellItemName)
    {
        UserData.haveItem.Remove(sellItemName);
        ChangeGold(5);
    }
}
