using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class cameratest : MonoBehaviour
{
    private WebCamTexture webcamTexture;
    private RawImage rawImage;
    public Image screenshotImage;

    private bool waitingForScreenshot = false;
    private float screenshotStartTime;
    private float displayDelay = 2f; // �\���̒x������

    public GameObject button;
    public GameObject button2;
    bool flag;
    float time;

    void Start()
    {
        // �E�F�u�J���e�N�X�`�����擾
        webcamTexture = new WebCamTexture();

        if (webcamTexture == null)
        {
            Debug.LogError("Failed to create WebCamTexture. Please make sure camera device is available.");
            return;
        }

        // RawImage�R���|�[�l���g���擾
        rawImage = GetComponent<RawImage>();

        if (rawImage == null)
        {
            Debug.LogError("RawImage component not found on the same GameObject as the cameratest script.");
            return;
        }

        // �E�F�u�J���e�N�X�`����RawImage�ɐݒ�
        rawImage.texture = webcamTexture;

        // �E�F�u�J�����J�n
        webcamTexture.Play();
    }

    void Update()
    {
        if (waitingForScreenshot)
        {
            if (Time.time >= screenshotStartTime + 0.1f)
            {
                TakeScreenshot();
                waitingForScreenshot = false;
                // �w�肵�����Ԍ�ɃX�N���[���V���b�g��\��
            }
        }


        if (flag == true)
        {
            time += Time.deltaTime;
        }
        if (time >= 0.2f)
        {
            button2.SetActive(true);
        }
    }

    // �X�N���[���V���b�g���B�鏀�����J�n
    public void StartScreenshotTimer()
    {
        waitingForScreenshot = true;
        screenshotStartTime = Time.time;
        button.SetActive(false);
        flag = true;
    }

    // �X�N���[���V���b�g���B��
    // �X�N���[���V���b�g���B��
    // �X�N���[���V���b�g���B��
    private string TakeScreenshot()
    {
        // �X�N���[���V���b�g���B�e
        string fileName = "Screenshot_" + System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";
        string filePath = Path.Combine(Application.persistentDataPath, fileName);

        // �X�N���[���V���b�g��ۑ�
        ScreenCapture.CaptureScreenshot(filePath);

        // �X�N���[���V���b�g���ۑ����ꂽ�p�X�����O�ɏo��
        Debug.Log("Screenshot saved to: " + filePath);
        //TakeAndDisplayScreenshot();
        // �t�@�C���p�X��Ԃ�
        return filePath;
       

    }

    // �X�N���[���V���b�g��\��
    private void DisplayScreenshot(string filePath)
    {
        if (File.Exists(filePath))
        {
            Debug.Log("File exists.");
        }
        else
        {
            Debug.Log("File does not exist.");
        }
        // �X�N���[���V���b�g��ǂݍ���ŕ\��
        if (File.Exists(filePath))
        {

            byte[] fileData = File.ReadAllBytes(filePath);
            Texture2D screenshotTexture = new Texture2D(2, 2);
            screenshotTexture.LoadImage(fileData);

            // �X�N���[���V���b�g��\������Image�R���|�[�l���g�Ƀe�N�X�`����ݒ�
            screenshotImage.sprite = Sprite.Create(screenshotTexture, new Rect(0, 0, screenshotTexture.width, screenshotTexture.height), Vector2.zero);

            // Image�I�u�W�F�N�g���A�N�e�B�u�ɂȂ�܂Ŏ��Ԃ�������ꍇ�����邽�߁A�����I�ɃA�N�e�B�u�ɂ���
            screenshotImage.gameObject.SetActive(true);

            // �X�N���[���V���b�g��\��
            screenshotImage.enabled = true;

            
        }
        else
        {
            Debug.Log("File does not exist: " + filePath);
        }
    }

    // �X�N���[���V���b�g���B���Ă���\���܂ł̈�A�̏���
    public void TakeAndDisplayScreenshot()
    {
        string filePath = TakeScreenshot();
        DisplayScreenshot(filePath);
    }


}
