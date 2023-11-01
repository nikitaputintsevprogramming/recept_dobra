using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CheckTrueButtons : MonoBehaviour
{
    [SerializeField] private GameObject[] _buttons;
    [SerializeField] private int _countAnswers;

    public void CheckAnswers()
    {
        if (_buttons[0].GetComponent<Image>().sprite.name == "clickedBtn")
        {
            if (_buttons[1].GetComponent<Image>().sprite.name == "clickedBtn")
            {
                if (_buttons[2].GetComponent<Image>().sprite.name == "clickedBtn")
                {
                    if (_buttons[3].GetComponent<Image>().sprite.name == "clickedBtn")
                    {
                        if (_buttons[4].GetComponent<Image>().sprite.name == "clickedBtn")
                        {
                            print("ok");
                        }
                    }
                }
            }
        }
           
    }
}
