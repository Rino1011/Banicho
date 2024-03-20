using UnityEngine;
using UnityEngine.SceneManagement;

public class image_wariai : MonoBehaviour
{
    float kekka;
    public static float kekka2;
    float now;
    float moku;

    public GameObject ev1;
    public GameObject ev2;
    public GameObject ev3;
    public GameObject ev4;
    public GameObject ev5;

    [SerializeField] public bool playOneShotFlag;
    public bool flagCache;

    [SerializeField] public bool playOneShotFlag2;
    public bool flagCache2;

    [SerializeField] public bool playOneShotFlag3;
    public bool flagCache3;

    [SerializeField] public bool playOneShotFlag4;
    public bool flagCache4;

    public static bool alreadyVisited10 = false; // 10に到達した場合のフラグ
    public static bool alreadyVisited20 = false; // 20に到達した場合のフラグ
    public static bool alreadyVisited30 = false; // 30に到達した場合のフラグ
    public static bool alreadyVisited40 = false; // 40に到達した場合のフラグ
    public static bool alreadyVisited50 = false; // 50に到達した場合のフラグ

    public static bool flag = false;
    public static bool flag2 = false;
    public static bool flag3 = false;
    public static bool flag4 = false;

    float time;

    void Start()
    {

    }

    void Update()
    {
        now = (float)button.nowmoney;
        moku = (float)button.mokuhyou;
        kekka = now / moku;
        kekka2 = kekka * 100;
        if(followesa.modori == true)
        {
        }


        if (kekka2 >= 100)
        {
            SceneManager.LoadScene("GameClear");
        }
        else if (kekka2 >= 80)
        {
            time += Time.deltaTime;
            if (flag4 == false)
            {
                ResetFlag();
            }
            if (time >= 0.01f)
            {
                ev1.SetActive(false);
                ev2.SetActive(false);
                ev3.SetActive(false);
                ev4.SetActive(false);
                ev5.SetActive(true);
            }
        }
        else if (kekka2 >= 60)
        {
            time += Time.deltaTime;
            if (flag3 == false)
            {
                ResetFlag();
            }
            if (time >= 0.01f)
            {
                ev1.SetActive(false);
                ev2.SetActive(false);
                ev3.SetActive(false);
                ev4.SetActive(true);
            }
        }
        else if (kekka2 >= 40)
        {
            time += Time.deltaTime;
            if (flag2 == false)
            {
                ResetFlag();
            }
            if (time >= 0.01f)
            {
                ev1.SetActive(false);
                ev2.SetActive(false);
                ev3.SetActive(true);
            }
        }
        else if (kekka2 >= 20)
        {
            time += Time.deltaTime;
            if (flag == false)
            {
                ResetFlag();
            }
            if (time >= 0.1f)
            {
                ev1.SetActive(false);
                ev2.SetActive(true);
            }
        }

    }
    void ResetFlag()
    {
        time = 0.0f;
        SceneManager.LoadScene("evolution");
    }
    void ResetFlag2()
    {
        time = 0.0f;
        SceneManager.LoadScene("evolution");
    }
    void ResetFlag3()
    {
        time = 0.0f;
        SceneManager.LoadScene("evolution");
    }
    void ResetFlag4()
    {
        time = 0.0f;
        SceneManager.LoadScene("evolution");
    }
}
