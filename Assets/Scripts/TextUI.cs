using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    [SerializeField] private Sprite _clickedButton;
    [SerializeField] private Sprite _unClickedButton;

    public void Clicked()
    {
        GetComponent<Text>().color = Color.white;
        transform.parent.gameObject.GetComponent<Image>().sprite = _clickedButton;
    }
}
