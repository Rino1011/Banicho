using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class othermoney : MonoBehaviour
{
    public InputField inputField_othermoney;
    public Text text_othermoney;
    string othermoney_string = ""; // ������

    public static int other = 0;

    // Start is called before the first frame update
    void Start()
    {
        // othermoney_string = ""; // �s�v
    }

    // Update is called once per frame
    void Update()
    {
        // other = 0; // �s�v
        if (!string.IsNullOrEmpty(othermoney_string))
        {
            other = int.Parse(othermoney_string);
            Debug.Log(other);
        }
        else
        {
            Debug.Log("�ݒ肳��Ă��܂���B");
        }
    }

    public void InputText_othermoney()
    {
        text_othermoney.text = inputField_othermoney.text;
        othermoney_string = text_othermoney.text;
    }
}
