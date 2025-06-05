using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Serverselect_Scania : MonoBehaviour
{
    public GameObject canvas;
    public GameObject canvas2;
    public TextMeshProUGUI servernameText;

    public void OnClickButton()
    {
        canvas.SetActive(true);
        canvas2.SetActive(false);
        servernameText.text = "스카니아";
    }
}
