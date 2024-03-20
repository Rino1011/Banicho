using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ev_button : MonoBehaviour
{
    public GameObject text;
    int visitcount;
    bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        if (image_wariai.kekka2 >= 20)
        {
            image_wariai.flag = true;
        }
        if (image_wariai.kekka2 >= 40)
        {
            image_wariai.flag2 = true;
        }
        if (image_wariai.kekka2 >= 60)
        {
            image_wariai.flag3 = true;
        }
        if (image_wariai.kekka2 >= 80)
        {
            image_wariai.flag4 = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(visitcount);
  
    }
    public void OnClick()
    {
        SceneManager.LoadScene("Main");
        //image_wariai.alreadyVisited = true;
    }
}
