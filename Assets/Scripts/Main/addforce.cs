using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce : MonoBehaviour
{

    bool isFirst = true; // �ŏ��̈��𔻒肷��t���O
    public static bool click; 

    public void force()
    {
        isFirst = false;  // ���͂�����
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();  // rigidbody���擾
        Vector2 force = new Vector2(0.0f, 5.0f);  // �͂�ݒ�
        rb.AddForce(force, ForceMode2D.Impulse);          // �͂�������
        esakesu.flag3 = false;
        click = true;
    }

}