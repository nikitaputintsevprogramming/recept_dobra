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
            // Получаем компонент Image для доступа к спрайту кнопки
            Image buttonImage = _buttons[i].GetComponent<Image>();

            // Проверяем, является ли имя спрайта "clickedBtn"
            if (buttonImage.sprite.name == "clickedBtn")
            {
                // Ответ выбран
                // Ваши действия, когда ответ правильный
            }
            else
            {
                // Ответ не выбран
                // Ваши действия, когда ответ неправильный
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
