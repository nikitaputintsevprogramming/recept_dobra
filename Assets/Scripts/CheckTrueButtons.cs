using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CheckTrueButtons : MonoBehaviour
{
    [SerializeField] private GameObject[] _buttons;
    [SerializeField] private int _countAnswers;

    [SerializeField] private bool[] _answers;

    public void CheckAnswers()
    {
        bool isAnswerCorrect = true;

        // Проверяем выбранные ответы
        for (int i = 0; i < _buttons.Length; i++)
        {
            bool isSelected = _buttons[i].GetComponent<Image>().sprite.name == "clickedBtn";

            // Проверяем, является ли выбранный ответ правильным
            if (isSelected && !_answers[i])
            {
                isAnswerCorrect = false;
                break;
            }
            else if (!isSelected && _answers[i])
            {
                isAnswerCorrect = false;
                break;
            }
        }

        // Выводим результат
        if (isAnswerCorrect)
        {
            Debug.Log("Правильные ответы выбраны!");
        }
        else
        {
            Debug.Log("Неправильные ответы выбраны.");
        }
    }

}
