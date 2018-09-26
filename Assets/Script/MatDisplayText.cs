using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MatDisplayText : MonoBehaviour{

    public static string text = "Welcome To Food";

    void Update ()
    {
        GetComponent<TextMeshPro>().text = text;
    }

    public static void ChangeText(string textInput)
    {
        text = textInput;
    }
}
