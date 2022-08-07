using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour, IPointerClickHandler
{
    public static InventoryItem selectedItem;
    public Image icon;

    public void OnPointerClick(PointerEventData eventData)
    {
        print($"{icon.sprite.name} 선택하자");
        selectedItem = this;
    }

    internal void Init(Sprite item)
    {
        icon.sprite = item;
    }
}
