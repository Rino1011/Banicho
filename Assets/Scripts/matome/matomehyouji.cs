using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class matomehyouji : MonoBehaviour
{
    public GameObject Text_one;
    public Text text_one;

    public GameObject Text_two;
    public Text text_two;

    public GameObject Text_three;
    public Text text_three;

    public GameObject Text_four;
    public Text text_four;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        Text text_one = Text_one.GetComponent<Text>();
        Text text_two = Text_two.GetComponent<Text>();
        Text text_three = Text_three.GetComponent<Text>();
        Text text_four = Text_four.GetComponent<Text>();

        text_one.text = nisuu.intValue.ToString() + "�~";
        text_two.text = input.mokuteki;
        text_three.text =nisuu.daysDifference.ToString() + "��";
        text_four.text =input.mokuhyou.ToString() + "�~";

        Debug.Log("1���̖ڕW�z" + input.oneday);//1���̒����z
        Debug.Log("�����ړI" + input.mokuteki);//�����ړI
        Debug.Log("�ڕW�B�����܂ł��Ɖ���" + nisuu.daysDifference);//�ڕW�B�����܂ł��Ɖ���
        Debug.Log("�ڕW�z" + input.mokuhyou);//1���̒����z
    }

    public void Modoru()
    {
        SceneManager.LoadScene("Main");
    }
}
