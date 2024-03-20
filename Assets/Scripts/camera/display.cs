using UnityEngine;

public class display : MonoBehaviour
{
    private Renderer renderer;

    void Start()
    {
        // Renderer‚ğæ“¾
        renderer = GetComponent<Renderer>();
        if (renderer == null)
        {
            Debug.LogError("Renderer component not found!");
        }
    }

    void Update()
    {
        // Material‚ªİ’è‚³‚ê‚Ä‚¢‚é‚©Šm”F
        if (renderer.material != null)
        {
            // Material‚ğ•\¦
            renderer.enabled = true;
        }
        else
        {
            Debug.LogError("Material is not assigned!");
        }
    }
}
