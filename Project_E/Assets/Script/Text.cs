using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    string myName = "김상준";
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
        Debug.Log("나이는 " + myAge + "입니다.");
        Debug.Log($"이름은 {myName}입니다.");
    }

    public void Selfheightandgender(float myHeight, string myMBTI)
    {
        Debug.Log("키는 " + myHeight + "입니다.");
        Debug.Log($"MBTI는 {myMBTI}입니다.");
    }

    public void Selfgenderandcolor()
    {
        Debug.Log("성별은 " + myGender + "입니다.");
        Debug.Log($"좋아하는 색은 {myColor}입니다.");
    }

    public void Selfcompanyandwine(string myCompany, string myWine)
    {
        Debug.Log("가고 싶은 회사는 " + myCompany + "입니다.");
        Debug.Log($"좋아하는 와인은 {myWine}입니다.");
    }

    public void Selfbeerandsoju(string myBeer, string mySoju)
    {
        Debug.Log("좋아하는 맥주는 " + myBeer + "입니다.");
        Debug.Log($"좋아하는 소주는 {mySoju}입니다.");
    }
}

