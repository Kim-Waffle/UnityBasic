using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    // õ�� �ý��� ī��Ʈ ����
    int count;
    private void Awake()
    {
        count = 1; // ī��Ʈ �ʱ�ȭ
    }

    public void Gatcha()

    {
        int number = 1;
        while (number <= 10)
        {
            int randomValue = Random.Range(1, 101); // 1���� 101�̸��� ������ �� ����

            // Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
            // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
            // ������ 70% Ȯ���� 'ġġ'�� �ʾƹ��ȴ�!

            Debug.Log($"{number}ȸ�� ������ ���� {randomValue} �Դϴ�");

            if (count >= 8)
            {
                Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
                count = 0; // õ�� ȹ�� �� ī��Ʈ �ʱ�ȭ
            }

            else if (randomValue >= 91)
            {
                Debug.Log("'��û'�� �̾Ҵ�!");
            }
            else if (randomValue >= 71)
            {
                Debug.Log("'��'�� �̾Ҵ�!");
            }
            else
            {
                Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
            }

            count++;

            number++;
        }

    }

    //public int selectNumber = 0;

    //public void GatchaSwitch()
    //{
    //    int randomValue = Random.Range(1, 101); // 1���� 101�̸��� ������ �� ����

    //    // Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
    //    // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
    //    // ������ 70%Ȯ���� 'ġġ'�� �ʾƹ��ȴ�!

    //    switch (selectNumber)
    //    {
    //        case 0:
    //            // ���� �Ӹ� ĳ���Ͱ� ���´�
    //            {
    //                if (randomValue <= 10) // 1 ~ 10 -> 10%
    //                {
    //                    // �Ⱦ� ĳ�� : �̹� �̱⿡ Ȯ���� ����  �����Ǵ� ĳ����
    //                    // �������� Ư�� ĳ���͸� ��ǥ�ϰ� �̰� ����� �ý���
    //                    Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
    //                }
    //                else if (randomValue <= 30) // 11 ~ 30
    //                {
    //                    Debug.Log("'��'�� �̾Ҵ�!");
    //                }
    //                else
    //                {
    //                    Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
    //                }
    //            }
    //            break;

    //        case 1:
    //            // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
    //            {
    //                if (randomValue <= 10) // 1 ~ 10 -> 10%
    //                {
    //                    Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
    //                }
    //                else if (randomValue <= 30) // 11 ~ 30
    //                {
    //                    Debug.Log("'��'�� �̾Ҵ�!");
    //                }
    //                else
    //                {
    //                    Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
    //                }
    //            }
    //            break;

    //        case 2:
    //            // ��ȫ �Ӹ� ĳ���Ͱ� ���´�
    //            {
    //                if (randomValue <= 10) // 1 ~ 10 -> 10%
    //                {
    //                    Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
    //                }
    //                else if (randomValue <= 30) // 11 ~ 30
    //                {
    //                    Debug.Log("'��'�� �̾Ҵ�!");
    //                }
    //                else
    //                {
    //                    Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
    //                }
    //            }
    //            break;

    //        default:
    //            // �Ķ� �Ӹ� ���� ĳ���Ͱ� ���´�.
    //            {
    //                if (randomValue <= 10) // 1 ~ 10 -> 10%
    //                {
    //                    Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
    //                }
    //                else if (randomValue <= 30) // 11 ~ 30
    //                {
    //                    Debug.Log("'��'�� �̾Ҵ�!");
    //                }
    //                else
    //                {
    //                    Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
    //                }
    //            }
    //            break;
    //    }
    //}

    //int count;

    //private void Awake()
    //{
    //    count = 0;
    //}

    //private void Start()
    //{
    //   for(int i = 0; i < 5; i++)
    //   {
    //        Debug.Log("�ݺ����� ����ƾ��~:)");
    //   }

    // Update is called once per frame
    void Update()
    {

    }
}
