using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public Sprite newSprite1; // ��������X�v���C�g
    public Sprite newSprite2; // ��������X�v���C�g
    public Sprite newSprite3; // ��������X�v���C�g
    public Sprite newSprite4; // ��������X�v���C�g
    public Sprite newSprite5; // ��������X�v���C�g
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // �t���O��True�ɂȂ����ꍇ�ɃX�v���C�g����������
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
