using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tab : MonoBehaviour
{
    public Image tabImage;
    public InventoryItem baseItem;
    //public List<InventoryItem> childsItems = new List<InventoryItem>();
    public List<InventoryItem> childsItems = new(); // 위와 같음
    private void CreateList(List<Sprite> items)
    {
        baseItem.gameObject.SetActive(true);
        foreach (Sprite item in items)
        {
            InventoryItem newItem = Instantiate(baseItem
                , baseItem.transform.parent);
            childsItems.Add(newItem);
            newItem.Init(item);
        }
        baseItem.gameObject.SetActive(false);
    }

    internal void Init(ShopInventoryUI.GameData gameData)
    {
        tabImage.sprite = gameData.tabIcon;
        CreateList(gameData.items);
    }

    public void SetActive(bool state)
    {
        childsItems.ForEach(x => x.gameObject.SetActive(state));
        GetComponent<Animator>().Play(state == true ? "ActiveTab" : "InactiveTab");   
    }
}
