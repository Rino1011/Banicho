using System;
using UnityEngine;
using UnityEngine.UI;

public class nisuu : MonoBehaviour
{
    public InputField dateInputField;
    public Text resultText;
    public Text dayresultText;
    public Text monthresultText;

    public static string inputDateString;
    public static int daysDifference;
    public static float oneday;
    public static float onemonth;

    public static float roundedNumber;
    public static float roundedNumbermonth;

    public static int intValue;
    void Start()
    {
        // ボタンに関数を登録
        Button calculateButton = GetComponent<Button>();
        calculateButton.onClick.AddListener(CalculateDateDifference);
    }

    void CalculateDateDifference()
    {
        // 入力された日付を取得
        inputDateString = dateInputField.text;

        // 日付が正しく解釈できるか確認
        if (DateTime.TryParse(inputDateString, out DateTime targetDate))
        {
            // 今日の日付を取得
            DateTime today = DateTime.Today;

            // 日数を計算
            TimeSpan difference = targetDate - today;
            daysDifference = difference.Days;

            // 結果を表示
            resultText.text = "達成予定日まで: " + daysDifference + "日";
        }
        else
        {
            // 日付が正しく解釈できなかった場合のエラーメッセージ
            resultText.text = "日付の形式が正しくありません。例: yyyy/MM/dd";
        }
        //Debug.Log(input.mokuhyou);
        //Debug.Log(daysDifference);
        oneday = input.floatValue / daysDifference;

        onemonth = oneday * 30;

        roundedNumber = Mathf.Ceil(oneday);
        roundedNumbermonth = Mathf.Ceil(onemonth);

        Debug.Log(oneday);
        Debug.Log(onemonth);
        Debug.Log(daysDifference);
        Debug.Log(input.mokuhyou);

        intValue = (int)roundedNumber;

        dayresultText.text = roundedNumber.ToString() + "円";
        monthresultText.text = roundedNumbermonth.ToString() + "円";
    }

    void Update()
    {
        
    }
}
