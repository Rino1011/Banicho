using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class othermoney : MonoBehaviour
{
    public InputField inputField_othermoney;
    public Text text_othermoney;
    string othermoney_string = ""; // 初期化

    public static int other = 0;

    // Start is called before the first frame update
    void Start()
    {
        // othermoney_string = ""; // 不要
    }

    // Update is called once per frame
    void Update()
    {
        // other = 0; // 不要
        if (!string.IsNullOrEmpty(othermoney_string))
        {
            other = int.Parse(othermoney_string);
            Debug.Log(other);
        }
        else
        {
            Debug.Log("設定されていません。");
        }
    }

    public void InputText_othermoney()
    {
        text_othermoney.text = inputField_othermoney.text;
        othermoney_string = text_othermoney.text;
    }
}
