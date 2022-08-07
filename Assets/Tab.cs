using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tab : MonoBehaviour
{
    public Image tabImage;
    public InventoryItem baseItem;
    private void CreateList(List<Sprite> items)
    {
        foreach (Sprite item in items)
        {
            InventoryItem newItem = Instantiate(baseItem
                , baseItem.transform.parent);
            newItem.Init(item);
        }
        baseItem.gameObject.SetActive(false);
    }

    internal void Init(ShopInventoryUI.GameData gameData)
    {
        tabImage.sprite = gameData.tabIcon;
        CreateList(gameData.items);
    }
}
