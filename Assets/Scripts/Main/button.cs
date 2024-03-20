using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public static int nowmoney;
    public static int oneday;
    public static int mokuhyou = 0;
    public Text nowmoney_text;

    public GameObject esa;
    // Start is called before the first frame update
    void Start()
    {
        nowmoney_text = nowmoney_text.GetComponent<Text>();
        //oneday = int.Parse(input.oneday_string);
        mokuhyou = input.mokuhyou;
    }

    // Update is called once per frame
    void Update()
    {
       nowmoney_text.text = nowmoney.ToString() + "‰~";
        if (mokuhyou <= nowmoney)
        {
            //SceneManager.LoadScene("achievement");
        }
        Debug.Log("oneday" + nisuu.oneday);
    }

    public void OnClick()
    {
        nowmoney += nisuu.intValue;
        //Debug.Log(nisuu.intValue);
        esa.SetActive(true);
    }
}
