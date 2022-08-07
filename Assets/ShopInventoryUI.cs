﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopInventoryUI : MonoBehaviour
{
    public List<GameData> gameDataList;
    public List<Tab> childsTabs = new();

    [System.Serializable]
    public class GameData
    {
        public Sprite tabIcon;
        public List<Sprite> items = new();
    }
    public Tab baseItem;
    private void Awake()
    {
        int index = 0;
        foreach (GameData gameData in gameDataList)
        {
            Tab TabItem = Instantiate(baseItem
                , baseItem.transform.parent);
            TabItem.Init(gameData);
            var button = TabItem.GetComponent<Button>();

            int setIndex = index;
            //button.onClick.AddListener(() => SelectTab(index));
            //button.onClick.AddListener(() => SelectTab(setIndex));
            button.AddListener(this, SelectTab1);
            index++;

            childsTabs.Add(TabItem);
        }
        baseItem.gameObject.SetActive(false);

        SelectTab(0);
    }
    void SelectTab1() => SelectTab(1);

    public void SelectTab(int tabIndex)
    {
        for (int i = 0; i < childsTabs.Count; i++)
        {
            childsTabs[i].SetActive(tabIndex == i);
        }
    }
}
