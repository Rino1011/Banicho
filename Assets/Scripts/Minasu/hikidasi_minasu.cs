using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hikidasi_minasu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        button.nowmoney -= minasu.minasucount;
        //Debug.Log(minasu.minasucount);
        Debug.Log(button.nowmoney);
        SceneManager.LoadScene("Main");
    }
}
