using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{

    public Image icon;

    internal void Init(Sprite item)
    {
        icon.sprite = item;
    }
}
