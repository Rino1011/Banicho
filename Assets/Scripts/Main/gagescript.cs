using UnityEngine;
using UnityEngine.UI;

public class gagescript : MonoBehaviour
{
    public Slider slider; // �Q�[�W�Ɏg�p���� Slider
    public float maxValue = 100f; // �ő�l
    public float increaseRate = 1f; // �������鑬�x

    private float currentValue = 0f; // ���݂̒l

    void Start()
    {
        // �Q�[�W�̏����l��ݒ�
        slider.value = 0f;
        currentValue = 0f;
    }

    void Update()
    {
        slider.value = image_wariai.kekka2 / maxValue;
    }
}
