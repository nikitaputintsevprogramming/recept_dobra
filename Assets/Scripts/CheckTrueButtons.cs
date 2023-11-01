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

        // ��������� ��������� ������
        for (int i = 0; i < _buttons.Length; i++)
        {
            bool isSelected = _buttons[i].GetComponent<Image>().sprite.name == "clickedBtn";

            // ���������, �������� �� ��������� ����� ����������
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

        // ������� ���������
        if (isAnswerCorrect)
        {
            Debug.Log("���������� ������ �������!");
        }
        else
        {
            Debug.Log("������������ ������ �������.");
        }
    }

}
