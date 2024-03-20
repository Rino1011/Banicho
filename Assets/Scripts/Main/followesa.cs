using UnityEngine;

public class followesa : MonoBehaviour
{
    private Vector2 originalPosition;
    private Vector2 targetPosition;
    public float speed = 1f;
    public static bool modori;
    public string targetTag;
    private GameObject target; // �ǐՑΏۂ̃I�u�W�F�N�g��GameObject
    public RectTransform targetRectTransform;

    void Start()
    {
        originalPosition = transform.position;
        targetPosition = originalPosition + new Vector2(1.5f, 0f);
        target = GameObject.FindGameObjectWithTag(targetTag);
        modori = false;
    }

    void Update()
    {
        Debug.Log(targetTag);
        if (kenti.Kenti == true)
        {
            if (esakesu.flag4 == true)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector2.MoveTowards(transform.position, targetPosition, step);

            }
            else
            {
                targetPosition = originalPosition;
                float step = speed * Time.deltaTime;
                transform.position = Vector2.MoveTowards(transform.position, targetPosition, step);
                if (Vector2.Distance(transform.position, originalPosition) < 0.001f)
                {
                    targetPosition = originalPosition + new Vector2(1.5f, 0f);

                }
            }
        }
        if (modori == true)
        {
            if (targetRectTransform != null)
            {
                // �ړ���̍��W���擾
                Vector3 targetPosition = targetRectTransform.position;

                // �������g�̍��W���ړ���̍��W�Ɍ����Ĉړ�
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }
        }
    }
}
