using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    string myName = "�����";
    int myAge = 29;
    float myHeight = 178.7f;
    string myMBTI = "INTP";
    bool myGender = true;
    string myColor = "Yellow";
    string myCompany = "NEXON";
    string myWine = "Cabernet Sauvignon";
    string myBeer = "Edelweiss";
    string mySoju = "Sero";

    void Start()
    {
        Selfintroduction();

        Selfheightandgender(myHeight, myMBTI);

        Selfgenderandcolor();

        Selfcompanyandwine(myCompany, myWine);

        Selfbeerandsoju(myBeer, mySoju);
    }

    public void Selfintroduction()
    {
        Debug.Log("���̴� " + myAge + "�Դϴ�.");
        Debug.Log($"�̸��� {myName}�Դϴ�.");
    }

    public void Selfheightandgender(float myHeight, string myMBTI)
    {
        Debug.Log("Ű�� " + myHeight + "�Դϴ�.");
        Debug.Log($"MBTI�� {myMBTI}�Դϴ�.");
    }

    public void Selfgenderandcolor()
    {
        Debug.Log("������ " + myGender + "�Դϴ�.");
        Debug.Log($"�����ϴ� ���� {myColor}�Դϴ�.");
    }

    public void Selfcompanyandwine(string myCompany, string myWine)
    {
        Debug.Log("���� ���� ȸ��� " + myCompany + "�Դϴ�.");
        Debug.Log($"�����ϴ� ������ {myWine}�Դϴ�.");
    }

    public void Selfbeerandsoju(string myBeer, string mySoju)
    {
        Debug.Log("�����ϴ� ���ִ� " + myBeer + "�Դϴ�.");
        Debug.Log($"�����ϴ� ���ִ� {mySoju}�Դϴ�.");
    }
}

