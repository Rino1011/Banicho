using UnityEngine;

public class esaookisa : MonoBehaviour
{
    //public bool shouldShrink = false; // 縮小するかどうかの条件
    public GameObject objectToShrink; // 縮小させるGameObject
    public float shrinkSpeed = 0.5f; // 縮小速度（1秒あたりのスケール変化量）

    private Vector3 initialScale; // 初期のスケール
    private float elapsedTime = 0f; // 経過時間

    void Start()
    {
        if (objectToShrink != null)
        {
            initialScale = objectToShrink.transform.localScale; // 初期のスケールを保存
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
                // 経過時間を更新
                elapsedTime += Time.deltaTime;

                // 新しいスケールを計算
                float scaleFactor = Mathf.Max(0f, 1f - shrinkSpeed * elapsedTime);
                Vector3 newScale = initialScale * scaleFactor;

                // スケールを設定
                objectToShrink.transform.localScale = newScale;
            }

            if (esakesu.flag == false)
            {
                objectToShrink.transform.localScale = initialScale;
                elapsedTime = 0f; // 経過時間をリセット
            }
        }
       

    }
}
