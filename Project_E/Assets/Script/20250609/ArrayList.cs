using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    public TextMeshProUGUI Txt_Bumin;

    string[] gotchaList = { "����", "��Ÿ", "����", "��Ÿ", "�ԽǷ�", "��Ÿ", "��Ÿ", "��Ÿ", "�̿�Ÿ", "ī��", "����", "��" };
    List<string> gotcha = new List<string>();

    public void ListGotcha()
    {
        string result;
        bool myuFound = false;

        for (int i = 0; i < gotchaList.Length; i++)
        {
            int randomValue = Random.Range(1, 101);

            if (randomValue == 100)
            {
                result = "��";
                myuFound = true;
            }
            else
            {
                int index = (randomValue - 1) / 9;
                result = gotchaList[index];
            }
            Debug.Log($"{i + 1}ȸ�� ���� ���: {result} (���� �� : {randomValue})");
        }

        if (myuFound)
        {
            Txt_Bumin.text = "�� ȹ��!";
        }
        else
        {
            Txt_Bumin.text = "�� ȹ�� ����!";
        }
    }
}


