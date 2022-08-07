using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventoryUI : MonoBehaviour
{
    public GameData gameData;
    public InventoryItem baseItem;

    [System.Serializable]
    public class GameData
    {
        //public Sprite tabIcon;
        public List<Sprite> items = new List<Sprite>();
    }
    private void Awake()
    {
        foreach (Sprite item in gameData.items)
        {
            InventoryItem newItem = Instantiate(baseItem
                , baseItem.transform.parent);
            newItem.Init(item);
        }
        baseItem.gameObject.SetActive(false);
    }
}
