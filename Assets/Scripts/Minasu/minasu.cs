using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minasu : MonoBehaviour
{
    public InputField inputField_othermoney;
    public Text text_othermoney;
    public string minasu_string;
    public static int minasucount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        minasucount = int.Parse(minasu_string);
    }
    public void InputText_othermoney()
    {
        text_othermoney.text = inputField_othermoney.text;
        minasu_string = text_othermoney.text;
        //Debug.Log(minasu_string);
        //mokuhyou_string = mokuhyou.ToString();
    }
}
