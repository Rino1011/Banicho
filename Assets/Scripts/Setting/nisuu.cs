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
        // �{�^���Ɋ֐���o�^
        Button calculateButton = GetComponent<Button>();
        calculateButton.onClick.AddListener(CalculateDateDifference);
    }

    void CalculateDateDifference()
    {
        // ���͂��ꂽ���t���擾
        inputDateString = dateInputField.text;

        // ���t�����������߂ł��邩�m�F
        if (DateTime.TryParse(inputDateString, out DateTime targetDate))
        {
            // �����̓��t���擾
            DateTime today = DateTime.Today;

            // �������v�Z
            TimeSpan difference = targetDate - today;
            daysDifference = difference.Days;

            // ���ʂ�\��
            resultText.text = "�B���\����܂�: " + daysDifference + "��";
        }
        else
        {
            // ���t�����������߂ł��Ȃ������ꍇ�̃G���[���b�Z�[�W
            resultText.text = "���t�̌`��������������܂���B��: yyyy/MM/dd";
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

        dayresultText.text = roundedNumber.ToString() + "�~";
        monthresultText.text = roundedNumbermonth.ToString() + "�~";
    }

    void Update()
    {
        
    }
}
