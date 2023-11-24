using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    [SerializeField] private Sprite _clickedButton;
    [SerializeField] private Sprite _unClickedButton;

    [SerializeField] private Button _next;

    public void Clicked()
    {
        if(transform.parent.gameObject.GetComponent<Image>().sprite == _clickedButton)
        {
            ClickOff();
        }
        else
        {
            ClickOn();
           
        }
    }

    private void ClickOn()
    {
        GetComponent<Text>().color = Color.white;
        transform.parent.gameObject.GetComponent<Image>().sprite = _clickedButton;

        _next.interactable = true;
    }

    private void ClickOff()
    {
        GetComponent<Text>().color = new Color32(236, 128, 58, 255);
        transform.parent.gameObject.GetComponent<Image>().sprite = _unClickedButton;
    }
}
