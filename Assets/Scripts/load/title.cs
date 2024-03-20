using UnityEngine;
using UnityEngine.UI;

public class title : MonoBehaviour
{
    public float fadeInTime = 1.0f; // フェードインにかかる時間（秒）
    public float maxOpacity = 1.0f; // 最大の不透明度
    public float fadeOutTime = 1.0f; // フェードアウトにかかる時間（秒）

    public GameObject rogo;

    private Image image;
    private bool fadingIn = true;
    private bool fadingOut = false;
    private float currentOpacity = 0.0f;
    private float timer = 0.0f;
    private float opacityStayDuration = 1.0f; // 不透明度が100%のままとどまる時間（秒）
    private bool opacityReachedMax = false;

    void Start()
    {
        image = GetComponent<Image>();
        if (image == null)
        {
            Debug.LogError("Imageコンポーネントがアタッチされていません！");
            enabled = false;
        }
    }

    void Update()
    {
        if (!opacityReachedMax)
        {
            if (fadingIn)
            {
                currentOpacity = Mathf.Lerp(0.0f, maxOpacity, timer / fadeInTime);
                if (timer < fadeInTime)
                {
                    timer += Time.deltaTime;
                }
                else
                {
                    fadingIn = false;
                    timer = 0.0f;
                    opacityReachedMax = true;
                }
            }
        }
        else
        {
            if (!fadingOut)
            {
                // 一定時間待機
                if (timer < opacityStayDuration)
                {
                    timer += Time.deltaTime;
                }
                else
                {
                    fadingOut = true;
                    timer = 0.0f;
                }
            }
            else
            {
                // フェードアウト
                currentOpacity = Mathf.Lerp(maxOpacity, 0.0f, timer / fadeOutTime);
                if (timer < fadeOutTime)
                {
                    timer += Time.deltaTime;
                }
                else
                {
                    fadingOut = false;
                    opacityReachedMax = false;
                    timer = 0.0f;
                    rogo.SetActive(false);
                }
            }
        }

        image.color = new Color(image.color.r, image.color.g, image.color.b, currentOpacity);
    }
}
