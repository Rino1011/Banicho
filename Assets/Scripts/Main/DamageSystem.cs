using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI使うときは忘れずに！
using UnityEngine.UI;

public class DamageSystem : MonoBehaviour
{

    //最大HP、半端な数にした
    [SerializeField]
    int maxHP = 120;
    //現在のHP
    [SerializeField]
    //public float currentHP;

    //public GameObject textObj;
    Text text;
    GameObject hpSystem;

    void Start()
    {
        //TextをGameObjectとして取得する
        //textObj = GameObject.Find("Text");
        //HPSystemを取得する
        hpSystem = GameObject.Find("HPSystem");
    }

    void Update()
    {
        //TextのTextコンポーネントにアクセス
        //(int)はfloatを整数で表示するためのもの
        //HPSystemのスクリプトのHPDown関数に2つの数値を送る
        hpSystem.GetComponent<HPSystem>().HPDown(image_wariai.kekka2, maxHP);
    }

    //FixedUpdateは一定に呼ばれるので持続的に使う処理に良いらしい
    void FixedUpdate()
    {
        //currentHPが0以上ならTrue
        if (0 <= image_wariai.kekka2)
        {
            //maxHPから秒数（×10）を引いた数がcurrentHP
            //image_wariai.kekka2 = maxHP - Time.time * 10;
        }
    }
}
