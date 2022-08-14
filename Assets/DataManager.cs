using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public List<GameItem> gameItems = new List<GameItem>();
    void Start()
    {
        var jsonTextAsset = Resources.Load("JsonData/GameItem") as TextAsset;
        var result = JsonConvert.DeserializeObject<List<GameItem>>(jsonTextAsset.text);
        print(result[0].Name);
    }
}

[System.Serializable]
public class GameItem
{
    public int ID;
    public string Name;
    public int Price;
}