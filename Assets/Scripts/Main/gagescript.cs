using UnityEngine;
using UnityEngine.UI;

public class gagescript : MonoBehaviour
{
    public Slider slider; // ゲージに使用する Slider
    public float maxValue = 100f; // 最大値
    public float increaseRate = 1f; // 増加する速度

    private float currentValue = 0f; // 現在の値

    void Start()
    {
        // ゲージの初期値を設定
        slider.value = 0f;
        currentValue = 0f;
    }

    void Update()
    {
        slider.value = image_wariai.kekka2 / maxValue;
    }
}
