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
    private float displayDelay = 2f; // 表示の遅延時間

    public GameObject button;
    public GameObject button2;
    bool flag;
    float time;

    void Start()
    {
        // ウェブカムテクスチャを取得
        webcamTexture = new WebCamTexture();

        if (webcamTexture == null)
        {
            Debug.LogError("Failed to create WebCamTexture. Please make sure camera device is available.");
            return;
        }

        // RawImageコンポーネントを取得
        rawImage = GetComponent<RawImage>();

        if (rawImage == null)
        {
            Debug.LogError("RawImage component not found on the same GameObject as the cameratest script.");
            return;
        }

        // ウェブカムテクスチャをRawImageに設定
        rawImage.texture = webcamTexture;

        // ウェブカムを開始
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
                // 指定した時間後にスクリーンショットを表示
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

    // スクリーンショットを撮る準備を開始
    public void StartScreenshotTimer()
    {
        waitingForScreenshot = true;
        screenshotStartTime = Time.time;
        button.SetActive(false);
        flag = true;
    }

    // スクリーンショットを撮る
    // スクリーンショットを撮る
    // スクリーンショットを撮る
    private string TakeScreenshot()
    {
        // スクリーンショットを撮影
        string fileName = "Screenshot_" + System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";
        string filePath = Path.Combine(Application.persistentDataPath, fileName);

        // スクリーンショットを保存
        ScreenCapture.CaptureScreenshot(filePath);

        // スクリーンショットが保存されたパスをログに出力
        Debug.Log("Screenshot saved to: " + filePath);
        //TakeAndDisplayScreenshot();
        // ファイルパスを返す
        return filePath;
       

    }

    // スクリーンショットを表示
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
        // スクリーンショットを読み込んで表示
        if (File.Exists(filePath))
        {

            byte[] fileData = File.ReadAllBytes(filePath);
            Texture2D screenshotTexture = new Texture2D(2, 2);
            screenshotTexture.LoadImage(fileData);

            // スクリーンショットを表示するImageコンポーネントにテクスチャを設定
            screenshotImage.sprite = Sprite.Create(screenshotTexture, new Rect(0, 0, screenshotTexture.width, screenshotTexture.height), Vector2.zero);

            // Imageオブジェクトがアクティブになるまで時間がかかる場合があるため、明示的にアクティブにする
            screenshotImage.gameObject.SetActive(true);

            // スクリーンショットを表示
            screenshotImage.enabled = true;

            
        }
        else
        {
            Debug.Log("File does not exist: " + filePath);
        }
    }

    // スクリーンショットを撮ってから表示までの一連の処理
    public void TakeAndDisplayScreenshot()
    {
        string filePath = TakeScreenshot();
        DisplayScreenshot(filePath);
    }


}
