using UnityEngine;

public class esaookisa : MonoBehaviour
{
    //public bool shouldShrink = false; // �k�����邩�ǂ����̏���
    public GameObject objectToShrink; // �k��������GameObject
    public float shrinkSpeed = 0.5f; // �k�����x�i1�b������̃X�P�[���ω��ʁj

    private Vector3 initialScale; // �����̃X�P�[��
    private float elapsedTime = 0f; // �o�ߎ���

    void Start()
    {
        if (objectToShrink != null)
        {
            initialScale = objectToShrink.transform.localScale; // �����̃X�P�[����ۑ�
        }
        else
        {
            Debug.LogError("objectToShrink is not assigned!");
        }
    }

    void Update()
    {
        if(kenti.Kenti == true)
        {
            if (esakesu.flag2 && objectToShrink != null)
            {
                // �o�ߎ��Ԃ��X�V
                elapsedTime += Time.deltaTime;

                // �V�����X�P�[�����v�Z
                float scaleFactor = Mathf.Max(0f, 1f - shrinkSpeed * elapsedTime);
                Vector3 newScale = initialScale * scaleFactor;

                // �X�P�[����ݒ�
                objectToShrink.transform.localScale = newScale;
            }

            if (esakesu.flag == false)
            {
                objectToShrink.transform.localScale = initialScale;
                elapsedTime = 0f; // �o�ߎ��Ԃ����Z�b�g
            }
        }
       

    }
}
