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

        [SerializeField] private Button _next;
        [SerializeField] private GameObject _uncorrectPanel;


        private void Start()
        {
            _next.interactable = false;
        }

        public void CheckAnswers()
        {
            isAnswerCorrect = true;

            // ��������� ��������� ������
            for (int i = 0; i < _buttons.Length; i++)
            {
                bool isSelected = _buttons[i].GetComponent<Image>().sprite.name == "clickedBtn";

                // ���������, �������� �� ��������� ����� ����������
                if (isSelected && !_answers[i])
                {
                    isAnswerCorrect = false;
                    SetUncorrect(_buttons[i].gameObject);
                    //break;
                }
                // ���������, �������� �� ��������� ����� ����������
                else if (!isSelected && _answers[i])
                {
                    isAnswerCorrect = false;
                    //break;
                }

                //else
                //{
                    //SetUncorrect(_buttons[i].gameObject);
                //}
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

        public void SetPage()
        {
            if (isAnswerCorrect)
            {
                _pageRect.GetComponent<PagedRect>().SetCurrentPage(_numTruePage);
            }
            else
            {
                _uncorrectPanel.SetActive(true);
                //_pageRect.GetComponent<PagedRect>().SetCurrentPage(_numFalsePage);
            }
        }

        [ContextMenu("Do red")]
        private void SetUncorrect(GameObject btn)
        {
            btn.GetComponentInChildren<Text>().color = Color.white;
            btn.GetComponent<Image>().color = new Color32(255, 0, 0, 255);

            _next.interactable = true;
        }
    }
}
