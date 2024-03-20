using UnityEngine;
using System.IO;

/// <summary>
/// スクリーンショットをキャプチャするサンプル
/// </summary>
public class texture : MonoBehaviour
{
    public Texture2D _targetTexture;

    void Start()
    {
        var storagePath = Application.dataPath + "/" + "test.png";

        //テクスチャの外側を定義
        Texture2D tex = new Texture2D(_targetTexture.width, _targetTexture.height);
        //ピクセル情報を入れる処理
        tex.SetPixels(_targetTexture.GetPixels());
        //エンコード処理
        var png = tex.EncodeToPNG();
        File.WriteAllBytes(storagePath, png);
    }
}