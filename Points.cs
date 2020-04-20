using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text point;
    public void display(int Score)
    {
        point.text = Score.ToString();
    }
}
