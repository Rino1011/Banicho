using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce : MonoBehaviour
{

    bool isFirst = true; // 最初の一回を判定するフラグ
    public static bool click; 

    public void force()
    {
        isFirst = false;  // 一回はすぎた
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();  // rigidbodyを取得
        Vector2 force = new Vector2(0.0f, 5.0f);  // 力を設定
        rb.AddForce(force, ForceMode2D.Impulse);          // 力を加える
        esakesu.flag3 = false;
        click = true;
    }

}