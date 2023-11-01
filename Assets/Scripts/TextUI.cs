using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    public void Clicked()
    {
        GetComponent<Text>().color = Color.white;
        transform.parent.gameObject.GetComponent<Image>().color = new Color32(236, 128, 58, 255);
    }
}
