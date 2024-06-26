using UnityEngine;

public class display : MonoBehaviour
{
    private Renderer renderer;

    void Start()
    {
        // Rendererを取得
        renderer = GetComponent<Renderer>();
        if (renderer == null)
        {
            Debug.LogError("Renderer component not found!");
        }
    }

    void Update()
    {
        // Materialが設定されているか確認
        if (renderer.material != null)
        {
            // Materialを表示
            renderer.enabled = true;
        }
        else
        {
            Debug.LogError("Material is not assigned!");
        }
    }
}
