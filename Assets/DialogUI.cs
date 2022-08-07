using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DialogUI : MonoBehaviour, IPointerClickHandler
{
    public Text text;
    public static DialogUI instance;
    private void Awake() => instance = this;

    public void ShowUI(string contents)
    {
        gameObject.SetActive(true);
        text.text = contents;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        gameObject.SetActive(false);
    }
}
