using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        foreach (GameData gameData in gameDataList)
        {
            Tab TabItem = Instantiate(baseItem
                , baseItem.transform.parent);
            TabItem.Init(gameData);
            childsTabs.Add(TabItem);
        }
        baseItem.gameObject.SetActive(false);

        SelectTab(0);
    }

    void SelectTab(int tabIndex)
    {
        for (int i = 0; i < childsTabs.Count; i++)
        {
            childsTabs[i].SetActive(tabIndex == i);
        }
    }
}
