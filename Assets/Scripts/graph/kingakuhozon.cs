using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class kingakuhozon : MonoBehaviour
{
    private int[] clickCounts = new int[30];
    private float[] startTimes = new float[30];
    private float timeWindow = 5f; // クリックが有効な時間枠（秒）
    private int currentIndex = 0;

    void Update()
    {
        // マウスがクリックされたら
        if (Input.GetMouseButtonDown(0))
        {
            // 現在の時間
            float currentTime = Time.time;

            // 新しい時間枠が必要かどうかをチェック
            if (currentTime - startTimes[currentIndex] > timeWindow)
            {
                currentIndex = (currentIndex + 1) % 30; // 次のインデックスに進む（30を超えたら最初の要素に戻る）
                startTimes[currentIndex] = currentTime; // 新しい時間枠の開始時刻を設定
                clickCounts[currentIndex] = 0; // クリック回数をリセット
            }

            // 変数を作成して、クリック回数を格納
            int newVariable = clickCounts[currentIndex]+ nisuu.intValue;
            Debug.Log("Variable " + currentIndex + ": " + newVariable);
        }
    }
}