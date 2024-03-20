using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public Sprite newSprite1; // 交換するスプライト
    public Sprite newSprite2; // 交換するスプライト
    public Sprite newSprite3; // 交換するスプライト
    public Sprite newSprite4; // 交換するスプライト
    public Sprite newSprite5; // 交換するスプライト
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // フラグがTrueになった場合にスプライトを交換する
        if (image_wariai.alreadyVisited10)
        {
            spriteRenderer.sprite = newSprite1;
        }
        else if (image_wariai.alreadyVisited20)
        {
            spriteRenderer.sprite = newSprite2;
        }
        else if (image_wariai.alreadyVisited30)
        {
            spriteRenderer.sprite = newSprite3;
        }
        else if (image_wariai.alreadyVisited40)
        {
            spriteRenderer.sprite = newSprite4;
        }
        else if (image_wariai.alreadyVisited50)
        {
            spriteRenderer.sprite = newSprite5;
        }
    }
}
