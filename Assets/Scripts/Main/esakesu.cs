using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esakesu : MonoBehaviour
{
    public BoxCollider2D ue;
    public static bool flag = false;
    public static bool flag2;
    public static bool flag3 = false;
    public static bool flag4 = false;
    public static bool onetime;
    float time;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("onetime = " + onetime);
        if (onetime == true)
        {
            //Debug.Log(time);
            if (flag == true)
            {
                time += Time.deltaTime;
                flag2 = true;
                flag3 = false;
            }

            if (time >= 0.3f)
            {
                ue.isTrigger = false;
                flag4 = true;
                

            }

            if (time >= 1.0f)
            {
                flag2 = false;
            }

            if (time >= 3.0f)
            {
                followesa.modori = true;
                //人帰りたい
                ball.SetActive(false);
                flag = false;
                time = 0.0f;
                ue.isTrigger = true;
                Vector3 currentPosition = ball.transform.position;

                // Y軸を-5に設定
                currentPosition.y = -1f;

                // 位置を更新
                ball.transform.position = currentPosition;
                flag3 = true;
                flag4 = false;
                onetime = false;
            }
            else
            {
                flag3 = false;
            }
        }
    }

    private void one()
    {
        onetime = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        flag = true;
        one();
    }

   
}
