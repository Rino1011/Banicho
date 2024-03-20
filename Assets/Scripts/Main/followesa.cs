using UnityEngine;

public class followesa : MonoBehaviour
{
    private Vector2 originalPosition;
    private Vector2 targetPosition;
    public float speed = 1f;
    public static bool modori;
    public string targetTag;
    private GameObject target; // 追跡対象のオブジェクトのGameObject
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
                // 移動先の座標を取得
                Vector3 targetPosition = targetRectTransform.position;

                // 自分自身の座標を移動先の座標に向けて移動
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }
        }
    }
}
