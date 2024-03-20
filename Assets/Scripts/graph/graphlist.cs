using System.Collections.Generic;
using UnityEngine;

public class graphlist : MonoBehaviour
{
    public List<int> recentValues = new List<int>();
    public int maxValuesToKeep = 30;

    // 新しい値を追加するメソッド
    public void AddNewValue(int value)
    {
        recentValues.Add(value);
        // リストのサイズがmaxValuesToKeepを超えた場合、古い値を削除する
        if (recentValues.Count > maxValuesToKeep)
        {
            recentValues.RemoveAt(0); // 先頭の値を削除
        }
    }

    // Startメソッドは例示のために使っていますが、実際には適切なタイミングでAddNewValueを呼び出してください
    void Start()
    {
        // 例：ランダムな値を追加してみる
        for (int i = 0; i < 10; i++)
        {
            AddNewValue(Random.Range(0, 100)); // 0から99の範囲のランダムな整数を追加
        }
    }
}
