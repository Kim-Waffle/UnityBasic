using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawstarif : MonoBehaviour
{
    // Start is called before the first frame update
    string star;
    void Start()
    {
        //Phase1();
        //Phase2();
        //Phase3();
        //Phase4();
        Phase5();
    }
    public void Phase5()
    {
        star = string.Empty;
        star += "\n"; // 시작 줄바꿈

        // 페이즈 5

        for (int i = 0; i < 9; i++)
        {
            if (i < 5)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    star += "　";
                }

                for (int k = 0; k < 2 * i + 1; k++)
                {
                    star += "★";
                }
            }
            else
            {
                for (int l = 0; l < i - 3; l++)
                {
                    star += "　";
                }
                for (int m = 0; m < 17 - 2 * i; m++)
                {
                    star += "★";
                }
                
            }
            star += "\n"; // 줄바꿈
        }
        Debug.Log(star);
    }
}
