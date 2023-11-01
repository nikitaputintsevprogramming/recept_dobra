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
            // �������� ��������� Image ��� ������� � ������� ������
            Image buttonImage = _buttons[i].GetComponent<Image>();

            // ���������, �������� �� ��� ������� "clickedBtn"
            if (buttonImage.sprite.name == "clickedBtn")
            {
                // ����� ������
                // ���� ��������, ����� ����� ����������
            }
            else
            {
                // ����� �� ������
                // ���� ��������, ����� ����� ������������
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
