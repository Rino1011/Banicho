using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    bool flag1;
    bool flag2;
    bool flag3;
    bool flag4;
    public GameObject tx1;
    public GameObject tx2;
    public GameObject tx3;
    // Start is called before the first frame update
    void Start()
    {
        flag1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(flag1 == true)
        {
            if (Input.GetMouseButtonDown(0))
            {

                tx1.SetActive(false);
                tx2.SetActive(true);

                flag1 = false;
                flag2 = true;
            }

        }
        else if(flag2 == true)
        {
            if (Input.GetMouseButtonDown(0))
            {

                tx2.SetActive(false);
                tx3.SetActive(true);

                flag2 = false;
                flag3 = true;
            }
        }
        else if (flag3 == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Setting");
            }
        }
    }

    public void OnClick()
    {
        if (flag3 == true)
        {
            SceneManager.LoadScene("Setting");
        }
    }
}
