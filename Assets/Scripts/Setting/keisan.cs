using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keisan : MonoBehaviour
{
    public int dateTimeNow;//現在時刻の数値化
    public int kakinDateTime;//課金有効日付の数値化
    public int mokuhyoubi;
    public int nokori;
    public InputField inputField_mokuhyou;
    public Text text_mokuhyou;
    public static string mokuhyou_string;
    // Start is called before the first frame update
    void Start()
    {
        inputField_mokuhyou = inputField_mokuhyou.GetComponent<InputField>();
        text_mokuhyou = text_mokuhyou.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        mokuhyoubi = int.Parse(mokuhyou_string);
        DateTime now = DateTime.Now;//端末の現在時刻の取得
        dateTimeNow = now.Year * 10000 + now.Month * 100 + now.Day;//日付を数値化　2020年9月1日だと20200901になる  

        nokori = mokuhyoubi - dateTimeNow;
        Debug.Log(nokori);
        //int day = now.Subtract(lastDate).Days;
    }
    public void InputText_mokuhyou()
    {
        text_mokuhyou.text = inputField_mokuhyou.text;
        mokuhyou_string = text_mokuhyou.text;
        //mokuhyou_string = mokuhyou.ToString();
    }
}
