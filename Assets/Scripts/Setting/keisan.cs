using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keisan : MonoBehaviour
{
    public int dateTimeNow;//���ݎ����̐��l��
    public int kakinDateTime;//�ۋ��L�����t�̐��l��
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
        DateTime now = DateTime.Now;//�[���̌��ݎ����̎擾
        dateTimeNow = now.Year * 10000 + now.Month * 100 + now.Day;//���t�𐔒l���@2020�N9��1������20200901�ɂȂ�  

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
