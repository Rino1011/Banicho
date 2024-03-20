using UnityEngine;

public class petcount : MonoBehaviour
{
    public static int visitCount; // 訪問回数を静的変数として定義


    void Start()
    {

        // 訪問回数をインクリメント
        visitCount++;

    }
}
