using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextpage : MonoBehaviour
{
    bool flag_one = false;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (button.mokuhyou >= button.oneday)
        {
            flag_one = true;
        }
    }

    public void OnClick()
    {
        Debug.Log(input.mokuhyou_string);
        Debug.Log(input.oneday_string);

        if (flag_one == true)
        {
            SceneManager.LoadScene(sceneName);
            Debug.Log("let'sgo!");
        }
        else
        {
            //Debug.Log("1“ú‚Ì’™‹àŠz‚ª‘½‚·‚¬‚Ü‚·B");
        }

    }
}