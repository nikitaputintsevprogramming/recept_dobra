using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace UI.Pagination
{
    public class CheckTrueButtons : MonoBehaviour
    {
        [SerializeField] private GameObject[] _buttons;
        [SerializeField] private int _countAnswers;

        [SerializeField] private bool[] _answers;

        [SerializeField] private GameObject _pageRect;
        [SerializeField] private bool isAnswerCorrect;
        [SerializeField] private int _numTruePage;
        [SerializeField] private int _numFalsePage;

        public void CheckAnswers()
        {
            isAnswerCorrect = true;

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

        public void SetPage()
        {
            if (isAnswerCorrect)
            {
                _pageRect.GetComponent<PagedRect>().SetCurrentPage(_numTruePage);
            }
            else
            {
                _pageRect.GetComponent<PagedRect>().SetCurrentPage(_numFalsePage);
            }
        }
    }
}
