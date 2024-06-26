using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI使うときは忘れずに！
using UnityEngine.UI;

public class HPSystem : MonoBehaviour
{

    public GameObject image;

    void Start()
    {
        //ImageをGameObjectとして取得
        image = GameObject.Find("Image");
    }

    //()の中身は引数、他のところから数値を得て{}の中で使う
    public void HPDown(float current, int max)
    {
        //ImageというコンポーネントのfillAmountを取得して操作する
        image.GetComponent<Image>().fillAmount = current / max;
    }
}