using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce : MonoBehaviour
{

    bool isFirst = true; // Å‰‚Ìˆê‰ñ‚ğ”»’è‚·‚éƒtƒ‰ƒO
    public static bool click; 

    public void force()
    {
        isFirst = false;  // ˆê‰ñ‚Í‚·‚¬‚½
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();  // rigidbody‚ğæ“¾
        Vector2 force = new Vector2(0.0f, 5.0f);  // —Í‚ğİ’è
        rb.AddForce(force, ForceMode2D.Impulse);          // —Í‚ğ‰Á‚¦‚é
        esakesu.flag3 = false;
        click = true;
    }

}