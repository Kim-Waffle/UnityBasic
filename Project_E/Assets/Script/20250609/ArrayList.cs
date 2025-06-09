using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    public TextMeshProUGUI Txt_Bumin;

    string[] gotchaList = { "¾ËÆÄ", "º£Å¸", "°¨¸¶", "µ¨Å¸", "ÀÔ½Ç·Ð", "Á¦Å¸", "ÀÌÅ¸", "½ÃÅ¸", "ÀÌ¿ÀÅ¸", "Ä«ÆÄ", "¶÷´Ù", "¹Â" };
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
                result = "¹Â";
                myuFound = true;
            }
            else
            {
                int index = (randomValue - 1) / 9;
                result = gotchaList[index];
            }
            Debug.Log($"{i + 1}È¸Â÷ »ÌÈù °á°ú: {result} (·£´ý °ª : {randomValue})");
        }

        if (myuFound)
        {
            Txt_Bumin.text = "¹Â È¹µæ!";
        }
        else
        {
            Txt_Bumin.text = "¹Â È¹µæ ½ÇÆÐ!";
        }
    }
}


