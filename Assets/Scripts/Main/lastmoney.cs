using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lastmoney : MonoBehaviour
{
    public Text last_text;
    int last;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        last_text.text = last.ToString() + "‰~";
        last = button.mokuhyou - button.nowmoney;
    }
}
