using UnityEngine;
using UnityEngine.UI;

public class title : MonoBehaviour
{
    public float fadeInTime = 1.0f; // �t�F�[�h�C���ɂ����鎞�ԁi�b�j
    public float maxOpacity = 1.0f; // �ő�̕s�����x
    public float fadeOutTime = 1.0f; // �t�F�[�h�A�E�g�ɂ����鎞�ԁi�b�j

    public GameObject rogo;

    private Image image;
    private bool fadingIn = true;
    private bool fadingOut = false;
    private float currentOpacity = 0.0f;
    private float timer = 0.0f;
    private float opacityStayDuration = 1.0f; // �s�����x��100%�̂܂܂Ƃǂ܂鎞�ԁi�b�j
    private bool opacityReachedMax = false;

    void Start()
    {
        image = GetComponent<Image>();
        if (image == null)
        {
            Debug.LogError("Image�R���|�[�l���g���A�^�b�`����Ă��܂���I");
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
                // ��莞�ԑҋ@
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
                // �t�F�[�h�A�E�g
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
