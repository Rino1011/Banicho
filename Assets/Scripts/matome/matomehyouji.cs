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

        text_one.text = nisuu.intValue.ToString() + "円";
        text_two.text = input.mokuteki;
        text_three.text =nisuu.daysDifference.ToString() + "日";
        text_four.text =input.mokuhyou.ToString() + "円";

        Debug.Log("1日の目標額" + input.oneday);//1日の貯金額
        Debug.Log("貯金目的" + input.mokuteki);//貯金目的
        Debug.Log("目標達成日まであと何日" + nisuu.daysDifference);//目標達成日まであと何日
        Debug.Log("目標額" + input.mokuhyou);//1日の貯金額
    }

    public void Modoru()
    {
        SceneManager.LoadScene("Main");
    }
}
