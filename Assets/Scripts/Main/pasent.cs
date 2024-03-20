using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pasent : MonoBehaviour
{
    public Text nowmoney_text;
    // Start is called before the first frame update
    void Start()
    {
        nowmoney_text = nowmoney_text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float roundedNumber = Mathf.Ceil(image_wariai.kekka2 * 1) / 1f;
        nowmoney_text.text = roundedNumber + "%"; 
    }
}
