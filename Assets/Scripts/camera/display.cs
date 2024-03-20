using UnityEngine;

public class display : MonoBehaviour
{
    private Renderer renderer;

    void Start()
    {
        // Renderer���擾
        renderer = GetComponent<Renderer>();
        if (renderer == null)
        {
            Debug.LogError("Renderer component not found!");
        }
    }

    void Update()
    {
        // Material���ݒ肳��Ă��邩�m�F
        if (renderer.material != null)
        {
            // Material��\��
            renderer.enabled = true;
        }
        else
        {
            Debug.LogError("Material is not assigned!");
        }
    }
}
