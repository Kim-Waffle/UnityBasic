using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawstar : MonoBehaviour
{
    string star;


    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;
        star += "\n"; // ���� �ٹٲ�

        // ������ 1

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                star += "��"; // ��
                //star += "��"; // ��ĭ
            }
            star += "\n"; // �ٹٲ�
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;
        star += "\n"; // ���� �ٹٲ�

        // ������ 2

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "��"; 
            }
            for (int k = 0; k < 5 - i; k++)
            {
                star += "��"; // ��
            }
            star += "\n"; // �ٹٲ�
        }


        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;
        star += "\n"; // ���� �ٹٲ�

        // ������ 3

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                star += "��"; // ��
            
            }
            star += "\n"; // �ٹٲ�
        }

        for (int m = 0; m < 4; m++)
        {
            for (int n = 0; n < 4 - m; n++)
            {
                star += "��"; // ��
            }
            star += "\n"; // �ٹٲ�
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;
        star += "\n"; // ���� �ٹٲ�

        // ������ 4

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5 - i; j++)
            {
                star += "��";
            }
            for (int k =  0; k < i + 1; k++)
            {
                star += "��";
            }
            star += "\n"; // �ٹٲ�
        }

        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < x + 2; y++)
            {
                star += "��";
            }
            for (int z = 0; z < 4 - x; z++)
            {
                star += "��"; // ��
            }
            star += "\n"; // �ٹٲ�
        }
        Debug.Log(star);
    }



    public void Phase5()
    {
        star = string.Empty;
        star += "\n"; // ���� �ٹٲ�

        // ������ 5

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5 - i; j++)
            {
                star += "��";
            }
            for (int k = 0; k < 2*i + 1; k++)
            {
                star += "��";
            }
            star += "\n"; // �ٹٲ�
        }

        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < x + 2; y++)
            {
                star += "��";
            }
            for (int z = 0; z < 7 - 2*x; z++)
            {
                star += "��";
            }
            star += "\n"; // �ٹٲ�
        }

        Debug.Log(star);
    }

    //public void Phase5()
    //{
    //    star = string.Empty;
    //    star += "\n"; // ���� �ٹٲ�

    //    // ������ 5

    //    for (int i = 0; i < 9; i++)
    //    {
    //        if (i < 5)
    //        {
    //            for (int j = 0; j < 5 - i; j++)
    //            {
    //                star += "��";
    //            }

    //            for (int k = 0; k < 2 * i + 1; k++)
    //            {
    //                star += "��";
    //            }
    //        }
    //        else
    //        {
    //            for (int l = 0; l < i - 3; l++)
    //            {
    //                star += "��";
    //            }
    //            for (int m = 0; m < 17 - 2 * i; m++)
    //            {
    //                star += "��";
    //            }

    //        }
    //        star += "\n"; // �ٹٲ�
    //    }
    //    Debug.Log(star);
    //}
}
