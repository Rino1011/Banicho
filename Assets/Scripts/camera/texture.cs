using UnityEngine;
using System.IO;

/// <summary>
/// �X�N���[���V���b�g���L���v�`������T���v��
/// </summary>
public class texture : MonoBehaviour
{
    public Texture2D _targetTexture;

    void Start()
    {
        var storagePath = Application.dataPath + "/" + "test.png";

        //�e�N�X�`���̊O�����`
        Texture2D tex = new Texture2D(_targetTexture.width, _targetTexture.height);
        //�s�N�Z���������鏈��
        tex.SetPixels(_targetTexture.GetPixels());
        //�G���R�[�h����
        var png = tex.EncodeToPNG();
        File.WriteAllBytes(storagePath, png);
    }
}