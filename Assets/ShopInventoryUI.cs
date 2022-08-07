using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopInventoryUI : MonoBehaviour
{
    public List<GameData> gameDataList;
    public List<Tab> childsTabs = new();
    public UserDataManager userDataManager;

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
            button.AddListener(this, () => SelectTab(setIndex));
            index++;

            childsTabs.Add(TabItem);
        }
        baseItem.gameObject.SetActive(false);

        SelectTab(0);
    }

    public void SelectTab(int tabIndex)
    {
        for (int i = 0; i < childsTabs.Count; i++)
        {
            childsTabs[i].SetActive(tabIndex == i);
        }
    }

    public void OnClickSelectedItemBuy()
    {
        if (InventoryItem.selectedItem == null)
        {
            Debug.LogWarning("선택된 아이템이 없음");
            return;
        }

        print($"{InventoryItem.selectedItem.icon.sprite.name} 사자");
        //UserData에 넣자.
        userDataManager.BuyItem(InventoryItem.selectedItem.icon.sprite.name);
        InventoryItem.selectedItem = null;
    }
}
