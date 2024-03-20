using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input : MonoBehaviour
{
    public InputField inputField_mokuhyou;
    public Text text_mokuhyou;

    public InputField inputField_mokuhyou2;
    public Text text_mokuhyou2;

    public static int mokuhyou = 0;
    public static int oneday = 0;

    public static string mokuhyou_string;
    public static string oneday_string;

    public static float floatValue;

    public static string mokuteki;

    void Start()
    {
        inputField_mokuhyou = inputField_mokuhyou.GetComponent<InputField>();
        text_mokuhyou = text_mokuhyou.GetComponent<Text>();

        inputField_mokuhyou2 = inputField_mokuhyou2.GetComponent<InputField>();
        text_mokuhyou2 = text_mokuhyou2.GetComponent<Text>();
        //PlayerPrefs.DeleteAll();
    }

    void Update()
    {

    }

    public void InputText_mokuhyou()
    {
        text_mokuhyou.text = inputField_mokuhyou.text;
        mokuhyou_string = text_mokuhyou.text;

        text_mokuhyou2.text = inputField_mokuhyou2.text;
         mokuteki = text_mokuhyou2.text;

         //mokuhyou_string = mokuhyou.ToString();
         mokuhyou = int.Parse(mokuhyou_string);
        floatValue = float.Parse(mokuhyou_string);
    }
}