using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventoryUI : MonoBehaviour
{
    public List<GameData> gameDataList;

    [System.Serializable]
    public class GameData
    {
        public Sprite tabIcon;
        public List<Sprite> items = new List<Sprite>();
    }
    public Tab baseItem;
    private void Awake()
    {
        foreach (GameData gameData in gameDataList)
        {
            Tab TabItem = Instantiate(baseItem
                , baseItem.transform.parent);
            TabItem.Init(gameData);
        }
        baseItem.gameObject.SetActive(false);
    }
}
